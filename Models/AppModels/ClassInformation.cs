namespace Models.AppModels
{
    public class ClassInformation
    {
        public int ClassInformationId { get; set; }
        public int GradeLevel { get; set; }
        public string Section { get; set; }

        public ClassInformation()
        { }

        public ClassInformation(int gradeLevel, string section)
        {
            GradeLevel = gradeLevel;
            Section = section;
        }
    }
}