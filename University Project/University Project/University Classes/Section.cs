namespace University_Project.university
{
    internal class Section
    {
        public int Id { get; set; }
        public string? NameofSection { get; set; }
      //  public List<Student> Students { get; set; } = new List<Student>();
        public int StudentId { get; set; }
        public Student? Student { get; set; }
        
    }
}
