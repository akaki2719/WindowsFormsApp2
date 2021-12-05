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
    public partial class TeacherForm : Form
    {
        List<User> Users = new List<User>();
        List<Homework> Homeworks = new List<Homework>();
        int lasthwid = 0;

        User Self = new User();
        public TeacherForm(List<User> registeredUsers, User self)
        {
            this.Users = registeredUsers;
            this.Self = self;
            InitializeComponent();
        }

        XmlDocument xmlcourses = new XmlDocument();
        XmlDocument xmlhomeworks = new XmlDocument();

        Course Course = new Course();

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
                    if(homework.SelectSingleNode("course").InnerText == Course.name)
                    {
                        Homework newHW = new Homework();
                        newHW.id = int.Parse(homework.SelectSingleNode("id").InnerText);
                        lasthwid = newHW.id;
                        newHW.title = homework.SelectSingleNode("title").InnerText;
                        newHW.description = homework.SelectSingleNode("description").InnerText;
                        foreach(XmlNode submission in homework.SelectSingleNode("Submissions").ChildNodes)
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


        private void TeacherForm_Load(object sender, EventArgs e)
        {
            chart_stats.Hide();
            label_teacherinfo.Text = Self.name + " " + Self.lastname + " (" + Self.course + ")";
            loadCourses();
            loadHomeworks();
            foreach (User student in Course.students)
            {
                dataGridView1.Rows.Add(false, student.id, student.name, student.lastname);
            }
            foreach (Homework homework in Homeworks)
            {
                dataGridView2.Rows.Add(false, homework.id, homework.title);
            }
        }

        private void button_getStats_Click(object sender, EventArgs e)
        {
            chart_stats.Series[0].Points.Clear();
            string selectedStudent = string.Empty;
            int selectedid = 0;
            bool found = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    found = true;
                    selectedid = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    selectedStudent += dataGridView1.Rows[i].Cells[2].Value.ToString() + " " + dataGridView1.Rows[i].Cells[3].Value.ToString();
                }
            }
            if (found)
            {
                chart_stats.Show();
                chart_stats.Titles[0].Text = selectedStudent;

                foreach (Grade grade in Course.grades)
                {
                    if (grade.studentid == selectedid)
                    {
                        chart_stats.Series[0].Points.AddXY(grade.date.ToString(), grade.mark);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select one of the students in DataGridView");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedStudent = string.Empty;
            int selectedid = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        if (j != i)
                            dataGridView1.Rows[i].Cells[0].Value = false;
                    }
                }
            }
        }

        private void button_giveGrade_Click(object sender, EventArgs e)
        {
            int selectedid = 0;
            bool found = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    found = true;
                    selectedid = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }
            if (found)
            {
                XmlNode grade = xmlcourses.CreateElement("grade");

                XmlNode studentid = xmlcourses.CreateElement("studentid");
                studentid.InnerText = selectedid.ToString();
                grade.AppendChild(studentid);

                XmlNode date = xmlcourses.CreateElement("date");
                date.InnerText = DateTime.Now.ToString("dd/MM");
                grade.AppendChild(date);

                XmlNode mark = xmlcourses.CreateElement("mark");
                mark.InnerText = textBox_giveGrade.Text;
                grade.AppendChild(mark);

                foreach (XmlNode course in xmlcourses.SelectSingleNode("Courses").ChildNodes)
                {
                    try
                    {
                        if (course.SelectSingleNode("name").InnerText == Course.name)
                        {
                            course.SelectSingleNode("Grades").AppendChild(grade);
                        }

                    }
                    catch
                    {

                    }
                }
                chart_stats.Series[0].Points.AddXY(date.InnerText, int.Parse(mark.InnerText));
                xmlcourses.Save("../../CourseList.xml");
                loadCourses();
            }
        }

        private void button_sendHW_Click(object sender, EventArgs e)
        {
            try
            {
                XmlElement homework = xmlhomeworks.CreateElement("homework");

                XmlElement submissions = xmlhomeworks.CreateElement("Submissions");

                XmlElement id = xmlhomeworks.CreateElement("id");
                id.InnerText = (lasthwid + 1).ToString();
                homework.AppendChild(id);

                XmlElement course = xmlhomeworks.CreateElement("course");
                course.InnerText = Course.name;
                homework.AppendChild(course);

                XmlElement title = xmlhomeworks.CreateElement("title");
                title.InnerText = textBox_hwTitle.Text;
                homework.AppendChild(title);

                XmlElement description = xmlhomeworks.CreateElement("description");
                description.InnerText = textBox_hwDescr.Text;
                homework.AppendChild(description);

                homework.AppendChild(submissions);

                xmlhomeworks.DocumentElement.AppendChild(homework);
                xmlhomeworks.Save("../../Homeworks.xml");

                MessageBox.Show("Homework successfully sent!");
                loadHomeworks();


            }
            catch
            {
                MessageBox.Show("Could not send the Homework...");
            }
        }

        private void button_checkSubm_Click(object sender, EventArgs e)
        {
            string selectedStudent = string.Empty;
            int selectedid = 0;
            bool found = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    found = true;
                    selectedid = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    selectedStudent += dataGridView1.Rows[i].Cells[2].Value.ToString() + " " + dataGridView1.Rows[i].Cells[3].Value.ToString();
                }
            }
            if (found)
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
                if (found1)
                {
                    bool found2 = false;
                    foreach(Homework homework in Homeworks)
                    {
                        if(homework.id == selectedHWId)
                        {
                            foreach(Submission submission in homework.submissions)
                            {
                                if (submission.st_id == selectedid)
                                {
                                    MessageBox.Show(submission.solution);
                                    found2 = true;
                                }
                            }
                            if(!found2)
                            {
                                MessageBox.Show("No submission yet.");

                            }
                        }
                    }
                }
                else { MessageBox.Show("Please select one of the homeworks in DataGridView"); }
            }
            else
            {
                MessageBox.Show("Please select one of the students in DataGridView");
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
    }
}
