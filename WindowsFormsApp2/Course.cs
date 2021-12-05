using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp2;

namespace SchoolProject
{
    public class Course
    {
        public string name;
        public User teacher;
        public List<User> students;
        public List<Grade> grades;

        public Course()
        {
            this.students = new List<User>();
            this.grades = new List<Grade>();
        }
    }
}
