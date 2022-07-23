namespace University_Project.university
{
    internal class Department
    {
        public int Id { get; set; }
        public string? NameofDepartment { get; set; }
        public int? FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
    }
}
