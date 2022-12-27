using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProgram
{
    public class Student
    {
        public int ApplicationNumber { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"номер {ApplicationNumber}, имя {FullName}, дата рождения {BirthDate}\n";
        }


    }
}