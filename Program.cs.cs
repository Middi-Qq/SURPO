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
        public Person()
        {
            Name = "John";
            Age = 20;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}