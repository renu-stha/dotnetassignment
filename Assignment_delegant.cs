using System;
class Publisher
{
    public delegate void Notify(); public event Notify Done;
    public void Start() { Console.WriteLine("Processing..."); Done?.Invoke(); }
}
class Subscriber { public void Msg() => Console.WriteLine("Completed notification received."); }
class Program { static void Main() { var p = new Publisher(); var s = new Subscriber(); p.Done += s.Msg; p.Start(); } }