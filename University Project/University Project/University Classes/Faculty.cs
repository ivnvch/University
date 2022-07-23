namespace University_Project.university
{
    internal class Faculty
    {
        public int Id { get; set; }
        public string? NameofFaculty { get; set; }
        public int? UniversityId { get; set; }
        public University? University { get; set; }
        public Dean_s_Office? _S_Office { get; set; }
    }
}
