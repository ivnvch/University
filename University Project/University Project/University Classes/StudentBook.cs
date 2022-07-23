namespace University_Project.university
{
    internal class StudentBook
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
