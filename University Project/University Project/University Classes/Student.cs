

namespace University_Project.university
{
    internal class Student:Person
    {
       // public int? Id { get; set; } //ID
        public int IdGroup { get; set; }//ID группы
        public int IdDepartment { get; set; }// ID кафедры
                                             // public string? Specialty { get; set; } //специальность
      // public List<Section> Sections { get; set; } = new List<Section>();
        public int? UniversityId { get; set; }
        public University? University { get; set; }
        public StudentBook? StudentBook { get; set; }
       
    }
}
