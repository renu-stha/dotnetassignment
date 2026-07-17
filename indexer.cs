using System;
class Student
{
    string[] n = new string[5];
    public string this[int i] { get => n[i]; set => n[i] = value; }
}
class Program
{
    static void Main()
    {
        var s = new Student();
        s[0] = "Ram"; s[1] = "Kalpana"; s[2] = "Hema"; s[3] = "Prem"; s[4] = "Gita";
        for (int i = 0; i < 5; i++) Console.WriteLine(s[i]);
    }
}