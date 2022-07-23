using Microsoft.EntityFrameworkCore;
using University_Project;
using University_Project.university;

using (UniversityContent univ = new UniversityContent())
{
    // univ.Database.EnsureDeleted();
    univ.Database.EnsureCreated();

    Student student = new Student { Name = "Дмитрий", Age = 20 };
    Student student1 = new Student { Name = "Ксения", Age = 17 };
    Student student2 = new Student { Name = "Александр", Age = 21 };
    univ.Students.AddRange(student, student1, student2);
    univ.SaveChanges();

    Country country = new Country { Name = "Беларусь" };
    univ.Countries.Add(country);
    City city = new City { Name = "Пинск", Country = country };
    univ.Cities.Add(city);
    univ.SaveChanges();

    University university = new University { Name = "Полесский Государственный Университет", City = city };
    univ.Universities.Add(university);

    Faculty faculty = new Faculty { NameofFaculty = "Инженерный факультет", University = university };//можно ли/нужно ли вместо университета писать его Id
    Faculty faculty1 = new Faculty { NameofFaculty = "Факультет экономики и финансов", University = university };
    univ.Faculties.AddRange(faculty, faculty1);
    univ.SaveChanges();

    Department department = new Department { NameofDepartment = "Кафедра инфомационных технологий и интеллектуальных систем", Faculty = faculty };
    univ.Departments.Add(department);
    Post post = new Post { Name = "Лектор" };
    Post post1 = new Post { Name = "Ассистент" };
    Post post2 = new Post { Name = "Старший преподаватель" };
    univ.Posts.AddRange(post, post1, post2);
    Teacher teacher = new Teacher { Name = "Людвик", Age = 66, Experience = 35, IdDepartment = 1, University = university, IdPosition = 1 };
    Teacher teacher1 = new Teacher { Name = "Ярослав", Age = 25, Experience = 4, IdDepartment = 1, University = university, IdPosition = 3 };
    univ.AddRange(teacher, teacher1);
    univ.SaveChanges();

    Console.WriteLine("Вывод данных");

    Console.WriteLine("\nСписок преподавателей: ");
    var teachers = univ.Teachers.ToList();
    foreach (var teach in teachers) Console.WriteLine(teach.Name);

}

using (UniversityContent univ = new UniversityContent())
{
    University university = new University { Name = "БГУ" };
    University university1 = new University { Name = "БГУиР" };
    University university2 = new University { Name = "БНТУ" };
    univ.Universities.AddRange(university, university1, university2);

    Teacher teacher = new Teacher { Name = "Alice", University = university };
    Teacher teacher1 = new Teacher { Name = "Chris", University = university2 };
    Teacher teacher2 = new Teacher { Name = "Tom", University = university1 };
    univ.Teachers.AddRange(teacher, teacher1, teacher2);
    univ.SaveChanges();
    Console.WriteLine("Имена преподавателей, и место их работы:");
    var teachers = univ.Teachers
        .Include(t => t.University)
        .ToList();
    foreach (var teach in teachers)
    {
        Console.WriteLine($"{teach.Name} - {teach.University?.Name}");
    }


}