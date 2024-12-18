using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETYUTB_Orai_Jelenlet_beadando.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Neptun { get; set; }
        public DateTime JoiningDate { get; set; }

        public Student() { }
        public Student(string name, string neptun, DateTime joiningDate)
        {
            Name = name;
            Neptun = neptun;
            JoiningDate = joiningDate;
        }
    }
}