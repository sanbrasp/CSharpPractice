using System.Collections.Concurrent;
using System.IO.Pipes;

namespace traditional_no_top_level;

public static class Lesson4
{
    public static void Run()
    {
        Console.WriteLine("=== Lesson 4: Classes and Objects ===");

        var person = new Person("Ada", 36);
        Console.WriteLine(person.Describe());

        person.HaveBirthday();
        Console.WriteLine(person.Describe());
        
        // Try invalid values to see validation in action
        try
        {
            var invalid = new Person("", -1); // Should throw
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Validation caught: {ex.Message}");
        }
    }
    
    // Domain type: Person
    private class Person
    {
        public string Name { get; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.", nameof(name));
            if (age < 0)
                throw new ArgumentException("Age cannot be negative.", nameof(age));
            
            Name = name;
            Age = age;
        }

        public void HaveBirthday() => Age++;
        public string Describe() => $"{Name} is {Age} years old.";
    }
}