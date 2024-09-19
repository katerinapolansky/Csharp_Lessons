namespace homework2;

public class BeginTask
{
    public void Begin1()
    {
        int a = 2;
        int p = 4 * a;
        Console.WriteLine(p);
    }

    public void Begin2()
    {
        double a = 1;
        double s = Math.Pow(a, 2);
        Console.WriteLine(s);
    }

    public void Begin3()
    {
        int a = 3;
        int b = 2;
        int s = a * b;
        int p = 2 * (a + b);
        Console.WriteLine($"Area is {s} and perimeter is {p}");
    }
}

public class Interger
{
    public void Integer1(int l)
    {
        int dist = l / 100;
        Console.WriteLine(dist);
    }

    public void Integer2(int m)
    {
        int ton = m / 1000;
        Console.WriteLine(ton);
    }
}

public class Boolean
{

    public void Boolean1(int number)
    {
        bool positive = number > 0;
        bool negative = number < 0;
    }

    public void Boolean2()
    {
        var a = int.TryParse(Console.ReadLine(), out int num);
        bool evenOrOdd = num % 2 == 0;
        if (evenOrOdd)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}

public class If
{
    public void If1(int a)
    {
        if (a > 0)
        {
            int b = a + 1;
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(a);
        }
    }
    
}