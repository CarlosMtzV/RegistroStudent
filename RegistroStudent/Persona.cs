using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroStudent
{
    public class Persona :NombrePersona
    {
       

        public string NameCompl{ get; set; }
        public DateTime Birthdai { get; set; }
        public Persona(string name, string fatherLN, string motherLN,DateTime birthdai) : base(name, fatherLN, motherLN)
        {
            this.NameCompl = name + fatherLN + motherLN;
            this.Birthdai = birthdai;
        }

        public override string ToString()
        {
            return base.ToString() + Birthdai;
        }
    }
}
