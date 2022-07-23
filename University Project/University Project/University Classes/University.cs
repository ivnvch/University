namespace University_Project.university
{
    internal class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Faculty>? Faculties { get; set; }//список факультетов
        public List<Department>? Departments { get; set; }//список кафедр
        public int? CityId { get; set; }
        public City? City { get; set; }
    }
}
