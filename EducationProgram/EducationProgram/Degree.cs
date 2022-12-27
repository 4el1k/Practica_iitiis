using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProgram
{
    public class Degree
    {
        public int Code { get; set; }
        public int CreditsRequired { get; set; }
        public int SpecialCoursesRequired { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return $"код {Code}, название {Title}," +
                $"\nкредитные единцы {CreditsRequired}, cпецкурсы {SpecialCoursesRequired} \n";
        }


    }
}