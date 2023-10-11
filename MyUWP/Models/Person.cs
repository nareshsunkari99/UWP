namespace MyUWP.Models
{
    public  class Person
    {
        public string Name { get; set; }
        public string Designation { get; set; }

        public static  Person GetPerson()
        {
            return new Person()
            {
                Name = "Naresh",
                Designation = "Associate Product Architect"
            };
        }
    }
}
