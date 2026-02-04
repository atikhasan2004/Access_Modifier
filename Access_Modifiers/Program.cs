using System;
class Person
{
    public string Name;       // Public field
    private int age;          // Private field
    public void SetAge(int a)   // Method to set age
    {
        if (a >= 0)
            age = a;
        else
            Console.WriteLine("Age cannot be negative");
    }

    public void ShowInfo()      // Method to show info
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + age);
    }
}
class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Atik Hasan";   // Public → can access directly
        p.SetAge(21);            // Private age set through method
        p.ShowInfo();            // Show output
    }
}
