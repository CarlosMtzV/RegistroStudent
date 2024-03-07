using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroStudent
{
    public class Student:Persona
    {
       
        public string Tuition { get; set; }
        public string Career { get; set; }
        public double Average { get; set; }

        public Student(double average,string career,string tuition ,string name, string fatherLN, string motherLN, DateTime birthdai) : base(name, fatherLN, motherLN, birthdai)
        {
        this.Tuition = tuition;
            this.Career = career;
            this.Average = average;
        }

        public override string ToString()
        {
            return base.ToString() + " "+Tuition + " "+Career + " "+Average;
        }
    }
}
