using System.Data;

namespace EducationProgram
{
    class Program
    {
        public static void Main()
        {
            MasterClass master = new MasterClass();
            master.Init();

            bool flag = true;

            while (flag)
            { 
                Console.WriteLine("***********************************");
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1. Просмотреть курсы.");
                Console.WriteLine("2. Квалификационная степень");
                Console.WriteLine("3. Список студентов");
                Console.WriteLine("4. Добавить учебную программу");
                Console.WriteLine("5. Добавить курс");
                Console.WriteLine("6. Просмотреть учебную программу");
                Console.WriteLine("7. Выйти");


                int k = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (k)
                {
                    case 1:
                        {
                            master.PrintCourses();
                            break;
                        }
                    case 2:
                        {
                            master.PrintDegrees();
                            break;
                        }
                    case 3:
                        {
                            master.PrintStudents();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите код учебной программы");
                            int codeCurriculum = int.Parse(Console.ReadLine());
                            if (master.ExistCurriculum(codeCurriculum))
                            {
                                break;
                            }

                            Console.WriteLine();

                            Console.WriteLine("Введите кода курсов");
                            string str = Console.ReadLine();
                            string[] strSplit = str.Split('/', StringSplitOptions.RemoveEmptyEntries);
                            foreach (string item in strSplit)
                            {
                                if (!master.CheckCorrectnessEnteredCourses(item))
                                {
                                    Console.WriteLine("Курсы введены некорректно. Возможно вы указали не все доп курсы.");
                                    break;
                                }
                            }                            
                            str.Replace('/', ',');
                            if (!master.CheckWorkCapacity(str, 2))
                            {
                                break;
                            }
                            Console.WriteLine();

                            Console.WriteLine("Введите код квалификаци");
                            int degrId = int.Parse(Console.ReadLine());
                            if (!master.ExistDegree(degrId))
                                break;
                            Console.WriteLine("Введите номер студента");
                            int numberStudent = int.Parse(Console.ReadLine());
                            if (!master.ExistStudent(numberStudent))
                                break;
                            Console.WriteLine("Введите дату создания YY.MM.DD");
                            string createDate = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine("Введите дату утверждения YY.MM.DD");
                            string confirmDate = Console.ReadLine();
                            Console.WriteLine();
                            master.AddNewCurriculum(codeCurriculum, numberStudent, degrId, str, createDate, confirmDate);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Введите код курса: ");
                            int code = int.Parse(Console.ReadLine());
                            if (master.ExistCourse(code))
                            {
                                break;
                            }
                            Console.WriteLine("Введите название курса: ");
                            string title = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine("Укажите тип курса: ");
                            Console.WriteLine("0. Общеобразовательный");
                            Console.WriteLine("1. Специальный");
                            int special = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Введите количество часов лекций: ");
                            int lectureHourse = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Введите количество часов практики: ");
                            int practiceHourse = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Наличие экзамена");
                            Console.WriteLine("0. Нет");
                            Console.WriteLine("1. В наличии");
                            int hEx = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Наличие курсовой работы");
                            Console.WriteLine("0. Нет");
                            Console.WriteLine("1. Есть");
                            int hSp = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Какие курсы должны быть выбраны вместе с этим курсом?" +
                                "(ввод через запятую ',' .");
                            master.PrintCourses();
                            string str = Console.ReadLine();
                            string[] prer = str.Split(',', StringSplitOptions.RemoveEmptyEntries);

                            master.AddNewCourse(code, title, special, lectureHourse, practiceHourse, hEx, hSp, str);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Введите код учебной программы");
                            int code = int.Parse(Console.ReadLine());
                            if (master.ExistCurriculum(code))
                            {
                                master.PrintCurriculum(code);
                            }
                            break;
                        }
                    case 7:
                        {
                            flag = false;
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}