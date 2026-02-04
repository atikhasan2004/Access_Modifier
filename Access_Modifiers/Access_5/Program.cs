using System;
class BaseClass
{
    protected int number;

}
class DerivedClass:BaseClass
{
    public void SetNumber(int n)
    {
        number=n;
    }
    public void ShowNumber()
    {
        Console.WriteLine($"Number= {number}");
    }
}
class Program
{
    static void Main()
    {
        DerivedClass DC=new DerivedClass();
        DC.SetNumber(22);
        DC.ShowNumber();
    }
}