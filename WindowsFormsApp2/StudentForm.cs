using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp2;

namespace SchoolProject
{
    public partial class StudentForm : Form
    {
        List<User> Users = new List<User>();
        User Self = new User();
        Course Course = new Course();
        List<Homework> Homeworks = new List<Homework>();
        int lasthwid = 0;
        XmlDocument xmlcourses = new XmlDocument();
        XmlDocument xmlhomeworks = new XmlDocument();
        public StudentForm(List<User>registeredUsers, User self)
        {
            this.Users = registeredUsers;
            this.Self = self;
            InitializeComponent();
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            loadCourses();
            loadHomeworks();
            label_studentinfo.Text = Self.name + " " + Self.lastname + " (" + Self.course + ")";

            chart_stats.Titles[0].Text = Self.name + " " + Self.lastname;

            foreach (Grade grade in Course.grades)
            {
                if (grade.studentid == Self.id)
                {
                    chart_stats.Series[0].Points.AddXY(grade.date.ToString(), grade.mark);
                }
            }
            foreach (Homework homework in Homeworks)
            {
                dataGridView2.Rows.Add(false, homework.id, homework.title);
            }
            dataGridView2.DataSource = SQLProcedures.SelectCourse();
        }
        public User findStudentById(int id)
        {
            foreach (User user in Users)
                if (user.id == id)
                    return user;
            return null;
        }
        public void loadCourses()
        {
            Course.name = Self.course;
            Course.teacher = Self;
            Course.grades.Clear();
            xmlcourses.Load("../../CourseList.xml");
            foreach (XmlNode course in xmlcourses.SelectSingleNode("Courses").ChildNodes)
            {
                try
                {
                    if (course.SelectSingleNode("name").InnerText == Course.name)
                    {
                        foreach (XmlNode studentid in course.SelectSingleNode("Students").ChildNodes)
                        {
                            User student = findStudentById(int.Parse(studentid.InnerText));
                            Course.students.Add(student);
                        }
                        foreach (XmlNode gr in course.SelectSingleNode("Grades").ChildNodes)
                        {
                            Grade grade = new Grade();
                            grade.date = gr.SelectSingleNode("date").InnerText;
                            grade.mark = int.Parse(gr.SelectSingleNode("mark").InnerText);
                            grade.studentid = int.Parse(gr.SelectSingleNode("studentid").InnerText);

                            Course.grades.Add(grade);
                        }
                    }

                }
                catch
                {
                }
            }
        }
        public void loadHomeworks()
        {
            xmlhomeworks.Load("../../Homeworks.xml");
            lasthwid = 0;

            foreach (XmlNode homework in xmlhomeworks.SelectSingleNode("Homeworks").ChildNodes)
            {
                try
                {
                    if (homework.SelectSingleNode("course").InnerText == Course.name)
                    {
                        Homework newHW = new Homework();
                        newHW.id = int.Parse(homework.SelectSingleNode("id").InnerText);
                        lasthwid = newHW.id;
                        newHW.title = homework.SelectSingleNode("title").InnerText;
                        newHW.description = homework.SelectSingleNode("description").InnerText;
                        foreach (XmlNode submission in homework.SelectSingleNode("Submissions").ChildNodes)
                        {
                            Submission subm = new Submission();
                            subm.id = int.Parse(submission.SelectSingleNode("id").InnerText);
                            subm.hw_id = newHW.id;
                            subm.st_id = int.Parse(submission.SelectSingleNode("student").InnerText);
                            subm.solution = submission.SelectSingleNode("solution").InnerText;
                            newHW.submissions.Add(subm);
                        }
                        Homeworks.Add(newHW);
                    }
                }
                catch
                {
                }
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[0].Value) == true)
                {
                    for (int j = 0; j < dataGridView2.RowCount; j++)
                    {
                        if (j != i)
                            dataGridView2.Rows[i].Cells[0].Value = false;
                    }
                }
            }
        }
        private void button_checkHW_Click(object sender, EventArgs e)
        {
            int selectedHWId = 0;
            bool found1 = false;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[0].Value) == true)
                {
                    found1 = true;
                    selectedHWId = int.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());

                }
            }
            if(found1)
            {
                foreach(Homework hw in Homeworks)
                {
                    if(hw.id == selectedHWId)
                    {
                        label_hw_title.Text = hw.title;
                        textBox_homework_description.Text = hw.description;
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please select one of the homeworks...");
            }
        }
        private void button_submit_hw_Click(object sender, EventArgs e)
        {
            int selectedHWId = 0;
            bool found1 = false;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[0].Value) == true)
                {
                    found1 = true;
                    selectedHWId = int.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                }
            }
            if(found1)
            {
                foreach(Homework hw in Homeworks)
                {
                    if(hw.id == selectedHWId)
                    {
                        try
                        {
                            XmlElement submission = xmlhomeworks.CreateElement("submission");

                            XmlElement subid = xmlhomeworks.CreateElement("id");
                            subid.InnerText = "9";
                            submission.AppendChild(subid);

                            XmlElement student = xmlhomeworks.CreateElement("student");
                            student.InnerText = Self.id.ToString();
                            submission.AppendChild(student);

                            XmlElement solution = xmlhomeworks.CreateElement("solution");
                            solution.InnerText = richTextBox_soution.Text;
                            submission.AppendChild(solution);

                            foreach (XmlNode node in xmlhomeworks.SelectSingleNode("Homeworks").ChildNodes)
                            {
                                if (node.SelectSingleNode("id").InnerText == selectedHWId.ToString())
                                {
                                    node.SelectSingleNode("Submissions").AppendChild(submission);
                                    break;
                                }
                            }
                            xmlhomeworks.Save("../../Homeworks.xml");
                            MessageBox.Show("Homework submited successfully!");
                        }
                        catch
                        {
                            MessageBox.Show("Failed to submit the homework...");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select one of the homeworks...");
            }
        }
    }
}
