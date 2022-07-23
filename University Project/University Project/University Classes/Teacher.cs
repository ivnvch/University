
namespace University_Project.university
{
    internal class Teacher:Person
    {
        public int Id { get; set; }
        public int IdDepartment { get; set; }//ID кафедры
        public int IdPosition { get; set; }//ID должности
        public int Experience { get; set; }//Стаж работы
        public int? UniversityId { get; set; }
        public University? University { get; set; }
        
    }
}
