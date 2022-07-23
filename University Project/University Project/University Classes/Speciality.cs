namespace University_Project.university
{
    internal class Speciality
    {
        public int Id { get; set; }
        public string? NameofSpeciality { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

    }
}
