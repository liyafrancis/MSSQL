// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Adder<T>
{
    public T Add(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x + y;
    }
}

class Program
{
    static void Main()
    {
        var intAdder = new Adder<int>();
        Console.WriteLine("Int addition: " + intAdder.Add(3, 5));

        var floatAdder = new Adder<float>();
        Console.WriteLine("Float addition: " + floatAdder.Add(3.5f, 2.4f));
    }
}
