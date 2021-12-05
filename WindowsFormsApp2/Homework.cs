using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Homework
    {
        public int id;
        public string course;
        public string title;
        public string description;
        public List<Submission> submissions;

        public Homework()
        {
            submissions = new List<Submission>();
        }
    }
}
