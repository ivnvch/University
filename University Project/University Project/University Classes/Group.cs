namespace University_Project.university
{
    internal class Group
    {
        public int Id { get; set; }
        public string? NameofGroup { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        public List<Student> Students { get; set; } = new();

    }
}
