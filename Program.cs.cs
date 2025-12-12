namespace GitPolytech;

public static class Program
{
    public static void Main(string[] args)
    {
        var person = new Person();
        Console.WriteLine(person.Name + "," + person.Age);
    }

    private class Person(string name, int age, bool gender)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public bool Gender { get; set; } = gender; // 1 - Man, 0 - Woman

        public Person() : this("John", 20, true)
        {
        }
    }
}