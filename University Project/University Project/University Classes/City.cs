namespace University_Project.university
{
    internal class City
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<University>? Universities { get; set; }
        public int CountryId { get; set; }
        public Country? Country { get; set; }

    }
}
