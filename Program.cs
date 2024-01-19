using System.Text;
namespace personCSVfile
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string City { get; set; }

            public Person( string name, int age, string city)
            {
                Name = name;
                Age = age;
                City = city;
            }

            public string ToCSVString()
            {
                return $"{Name}, {Age}, {City}";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Submit info for person:");
            Console.WriteLine("Submit name:");
            string name4 = Console.ReadLine();
            Console.WriteLine("Submit age:");
            int age4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Submit city:");
            string city4 = Console.ReadLine();

            Person person1 = new Person("Amanda", 13, "Uppsala");
            Person person2 = new Person("Sanna", 23, "Linköping");
            Person person3 = new Person("Christer", 55, "Västerås");
            Person person4 = new Person(name4, age4, city4);

            List<Person> people = new List<Person>() { person1, person2, person3, person4 };

            string csvFilePath = @"C:people.csv";

            using (StreamWriter writer = new StreamWriter(csvFilePath, false, Encoding.UTF8))
            {
                writer.WriteLine("Name,Age,City");
                foreach (var person in people)
                {
                    writer.WriteLine(person.ToCSVString());
                }
            }
            Console.WriteLine($"File has been saved to {csvFilePath}");
        }
    }
}
