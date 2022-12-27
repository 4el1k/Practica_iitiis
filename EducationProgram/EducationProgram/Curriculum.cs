using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProgram
{
    public class Curriculum
    {
        public int Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ConfirmationDate { get; set; }
        public Degree Degree { get; set; }
        public List<int> Course { get; set; }
        public Student Student { get; set; }

        private double cr;

        public override string ToString()
        {
            return $"студент: {Student}, код плана: {Code}," +
                $"\nдата создания: {CreationDate}, дата утверждения: {ConfirmationDate}," +
                $"\nкурсы: {string.Join(",", Course)}" +
                $"\nстепень: {Degree.Title}, количество кредитных единиц курса: {cr} \n";
        }
    }
}