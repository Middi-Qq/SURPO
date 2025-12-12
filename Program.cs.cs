namespace GitPolytech;

public static class Program
{
    public static void Main(string[] args)
    {
        var person = new Person();
        Console.WriteLine(person.Name + "," + person.Age);
    }

    private class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; } // 1 - Man, 0 - Woman

        public Person()
        {
            Name = "John";
            Age = 20;
            Gender = true;
        }

        public Person(string name, int age, bool gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}