using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EducationProgram
{
    public class MasterClass
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Degree> Degrees { get; set; } = new List<Degree>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Curriculum> Curriculums { get; set; } = new List<Curriculum>();
        public void Init()
        {
            Students.Clear();

            Students.Add(new Student
            {
                ApplicationNumber = 1,
                FullName = "Надопкунехотелов Александ Валерьевич",
                BirthDate = new DateTime(2003, 10, 20)
            });
            Students.Add(new Student
            {
                ApplicationNumber = 2,
                FullName = "Нафизрунеходилов Дмитрий Егоров",
                BirthDate = new DateTime(2002, 12, 16)
            });
            Students.Add(new Student
            {
                ApplicationNumber = 3,
                FullName = "Иванов Иван Иванович",
                BirthDate = new DateTime(2005, 08, 05)
            });
            Courses.Add(new Course
            {
                Code = 1,
                Title = "Основы математики",
                IsSpecial = false,
                LectureHours = 20,
                PracticeHours = 12,
                HasExam = false,
                HasCoursePaper = false,
                Prerequisities = new List<int> { 1 }
            });
            Courses.Add(new Course
            {
                Code = 2,
                Title = "Дисркеная математика",
                IsSpecial = false,
                LectureHours = 20,
                PracticeHours = 12,
                HasExam = false,
                HasCoursePaper = false,
                Prerequisities = new List<int> { 1 }
            });
            Courses.Add(new Course
            {
                Code = 3,
                Title = "Алгебра и геометрия",
                IsSpecial = true,
                LectureHours = 12,
                PracticeHours = 15,
                HasExam = true,
                HasCoursePaper = false,
                Prerequisities = new List<int> { 1 }
            });
            Courses.Add(new Course
            {
                Code = 4,
                Title = "Математический анализ",
                IsSpecial = true,
                LectureHours = 12,
                PracticeHours = 15,
                HasExam = true,
                HasCoursePaper = false,
                Prerequisities = new List<int> { 3 }
            });
            Courses.Add(new Course
            {
                Code = 5,
                Title = "Теория Вероятности",
                IsSpecial = true,
                LectureHours = 34,
                PracticeHours = 12,
                HasExam = true,
                HasCoursePaper = true,
                Prerequisities = new List<int> { 1, 2 }
            });
            Degrees.Add(new Degree
            {
                Code = 1,
                Title = "Бакалавриат",
                CreditsRequired = 5,
                SpecialCoursesRequired = 0
            });
            Degrees.Add(new Degree
            {
                Code = 2,
                Title = "Магистратура",
                CreditsRequired = 6,
                SpecialCoursesRequired = 1
            });
            Degrees.Add(new Degree
            {
                Code = 3,
                Title = "Аспирантура",
                CreditsRequired = 7,
                SpecialCoursesRequired = 1
            });
        }

        public void PrintStudents()
        {

            Console.WriteLine("Список студентов;");
            foreach (var prod in Students)
            {
                Console.WriteLine(prod);
            }
        }

        public void PrintDegrees()
        {
            Console.WriteLine("Список квалификаций;");
            foreach (var cust in Degrees)
            {
                Console.WriteLine(cust);
            }
        }

        public void PrintCourses()
        {
            Console.WriteLine("Список курсов;");
            foreach (var ord in Courses)
            {
                Console.WriteLine(ord);
            }
        }

        public void PrintCurriculum(int code)
        {
            foreach (var c in Curriculums)
            {
                if (c.Code == code)
                {
                    Console.WriteLine(c);
                    return;
                }
            }
            Console.WriteLine("Учебной программы с таким кодом не существует");
        }

        public bool ExistStudent(int number)
        {
            foreach (var c in Students)
            {
                if (c.ApplicationNumber == number)
                    return true;
            }
            return false;
        }

        public bool ExistDegree(int code)
        {
            foreach (var c in Degrees)
            {
                if (c.Code == code)
                    return true;
            }
            return false;
        }

        public bool ExistCourse(int code)
        {
            foreach (var p in Courses)
            {
                if (p.Code == code)
                    return true;
            }
            return false;
        }

        public bool ExistCurriculum(int code)
        {
            foreach (var c in Curriculums)
            {
                if (c.Code == code)
                    return true;
            }
            return false;
        }

        public void AddNewCourse(int code, string title, int special, int lectureHourse, int practiceHourse, int int_hasExam, int int_hasCoursePaper, string str)
        {
            bool isSpecial = ConvertIntToBool(special);
            bool hasExam = ConvertIntToBool(int_hasExam);
            bool hasCoursePaper = ConvertIntToBool(int_hasCoursePaper);
            string[] prer = str.Split(',', StringSplitOptions.RemoveEmptyEntries);
            var prerequisities = ConvertArrayStringDigitsToList(prer);
            Courses.Add(new Course
            {
                Code = code,
                Title = title,
                IsSpecial = isSpecial,
                LectureHours = lectureHourse,
                PracticeHours = practiceHourse,
                HasExam = hasExam,
                HasCoursePaper = hasCoursePaper,
                Prerequisities = prerequisities
            });
        }

        //юзер выбирает основные курсы
        //идет проверка есть ли в списках курсы, которые допом должны обязательно быть вместе с остальными
        //если всё окей, считается трудоемкость (WorkCapacity)
        //если WorkCapacity достаточен то работаем!
        //всё выше перечисленное происходит в main классе programm, с помощью методов из класса MasterClass, т.е. из этого класса
        public void AddNewCurriculum(int codeCurriculum,int numberStudent, int degreeCode, string courseCode,  string creatDate, string confirmDate)
        {
            //ToDo
            Student student = null;
            Degree degree = null;
            Course course = null;
            DateTime creatinoDate = ConvertStringToDataTime(creatDate);
            DateTime confirmationDate = ConvertStringToDataTime(confirmDate);
            foreach (var stud in Students)
            {
                if (stud.ApplicationNumber == numberStudent)
                {
                    student = stud;
                }
            }
            foreach (var degr in Degrees)
            {
                if (degr.Code == degreeCode)
                {
                    degree = degr;
                }
            }

            string[] courseArray = courseCode.Split(',', StringSplitOptions.RemoveEmptyEntries);

            Curriculums.Add(new Curriculum
            {
                Student = student,
                Degree = degree,
                Course = ConvertStringArrayToListInt(courseArray),
                Code = codeCurriculum,
                CreationDate = ConvertStringToDataTime(creatDate),
                ConfirmationDate = ConvertStringToDataTime(confirmDate)
            });
        }

        public bool CheckCorrectnessEnteredCourses(string str)
        {
            string[] courses = str.Split(',', StringSplitOptions.RemoveEmptyEntries);
            Course mainCourse = GetCourse(int.Parse(courses[0]));
            Course prerequisitiesCourse = null;
            bool result = false;
            bool intermediateResult;
            for (int i = 1; i < courses.Length; i++)
            {
                intermediateResult = false;
                prerequisitiesCourse = GetCourse(int.Parse(courses[i]));
                foreach (int course in mainCourse.Prerequisities)
                {
                    if (prerequisitiesCourse.Code == GetCourse(course).Code)
                    {
                        intermediateResult = true;
                        break;
                    }
                }
                if (!intermediateResult)
                {
                    return false;
                }
            }
            return true;
        }

        public Course GetCourse(int courseCode)
        {
            foreach (var course in Courses)
            {
                if (course.Code == courseCode)
                {
                    return course;
                }
            }
            return null;
        }

        public bool CheckWorkCapacity(string str, byte wc)
        {
            string[] listCourses = str.Split(',', StringSplitOptions.RemoveEmptyEntries);
            int courseCode;
            byte workCapacity=0;
            Course course = null;
            foreach (var code in listCourses)
            {
                course = GetCourse(int.Parse(code));
                workCapacity += course.WorkCapacity;
            }
            if (workCapacity >= wc)
                return true;
            return false;
        }

        public bool ExistCourses(string str)
        {
            string[] courses = str.Split(',', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < courses.Length; i++)
            {
                if (!ExistCourse(int.Parse(courses[i])));
                {
                    return false;
                }
            }
            return true;
        }

        public List<int> ConvertStringArrayToListInt(string[] str)
        {
            List<int> list = new List<int>();
            foreach (var item in str)
            {
                list.Add(int.Parse(item));
            }
            return list;
        }

        private DateTime ConvertStringToDataTime(string str)
        {
            string[] strSplit = str.Split('.', StringSplitOptions.RemoveEmptyEntries);
            return new DateTime(int.Parse(strSplit[0]), int.Parse(strSplit[1]), int.Parse(strSplit[2]));
        }

        private bool ConvertIntToBool(int a)
        {
            if (a == 1)
            {
                return true;
            }
            return false;
        }

        private List<int> ConvertArrayStringDigitsToList(string[] str)
        {
            var result = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                result.Add(int.Parse(str[i]));
            }
            return result;
        }
    }
}