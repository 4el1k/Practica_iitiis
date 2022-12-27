namespace EducationProgram
{
    public class Course
    {
        public int Code { get; set; }
        public bool HasCoursePaper { get; set; }
        public bool HasExam { get; set; }
        public bool IsSpecial { get; set; }
        public int LectureHours { get; set; }
        public int PracticeHours { get; set; }
        public List<int> Prerequisities { get; set; }
        public string Title { get; set; }
        public byte WorkCapacity
        {
            get
            {
                return (byte)Math.Round((LectureHours + 1.25 * PracticeHours) / 18);
            }
            private set { }
        }
        public override string ToString()
        {
            return $"код {Code}, название {Title}, наличие спецкурса  {IsSpecial}," +
                $"\nчасов лекций  {LectureHours}, часы практики  {PracticeHours}, наличие экамена  {HasExam}," +
                $"\nкурсовая работа {HasCoursePaper}, обязательные курсы №  {string.Join(",", Prerequisities)} \n";
        }
    }
}