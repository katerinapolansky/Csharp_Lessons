namespace homework3;

public class WhileTasks
{
    public void While2()
    {
        int a=10;
        int b=3;
        int counter = 0;
        int n;
        while (a > b)
        {
            a -= b;
            
            counter++;
        }
        Console.WriteLine(counter);
    }


    public void For8()
    {
        int a = 1;
        int b = 5;
        //var numbers = new List<int>();
        int mult = 1;
        for (int i = a; i <= b; i++)
        {
               
            //numbers.Add(i);
            mult = mult * i;

        }
        
        Console.WriteLine(mult);
    }

    public void Case3()
    {
        Console.Write("Enter a number: ");
        var n = int.Parse(Console.ReadLine());
        switch (n) 
        { 
            case 1:
                Console.WriteLine("Winter");
                break; 
            case 2:
                Console.WriteLine("Winter");
                break; 
            case 3:
                Console.WriteLine("Spring");
                break; 
            case 4:
                Console.WriteLine("Spring");
                break; 
            case 5:
                Console.WriteLine("Spring");
                break; 
            case 6:
                Console.WriteLine("Spring");
                break; 
            case 7:
                Console.WriteLine("Summer");
                break; 
            case 8:
                Console.WriteLine("Summer");
                break; 
            case 9:
                Console.WriteLine("Autumn");
                break; 
            case 10:
                Console.WriteLine("Autumn");
                break; 
            case 11:
                Console.WriteLine("Autumn");
                break; 
            case 12:
                Console.WriteLine("Winter");
                break; 
            default: 
                Console.WriteLine("no season");
                break; 
        }
    }

    public void Boolean9()
    {
        var a = int.TryParse(Console.ReadLine(), out int num1);
        var b = int.TryParse(Console.ReadLine(), out int num2);
        bool evenOrOdd = num1 % 2 != 0 || num2 % 2 != 0;
        if (evenOrOdd)
        {
            Console.WriteLine("At least one number is odd");
        }
        else
        {
            Console.WriteLine("All numbers are even");
        }
    }
    
    public void Boolean12()
    {
        var a = int.TryParse(Console.ReadLine(), out int num1);
        var b = int.TryParse(Console.ReadLine(), out int num2);
        var c = int.TryParse(Console.ReadLine(), out int num3);
        bool ifPositive = num1 > 0 && num2 > 0 && num3 > 0;
        if (ifPositive)
        {
            Console.WriteLine("All numbers are positive");
        }
        else
        {
            Console.WriteLine("Not all of them");
        }
    }
    
    public void Boolean14()
    {
        var a = int.TryParse(Console.ReadLine(), out int num1);
        var b = int.TryParse(Console.ReadLine(), out int num2);
        var c = int.TryParse(Console.ReadLine(), out int num3);
        bool ifPositive1 = (num1 > 0);
        bool ifPositive2 = (num2 < 0);
        bool ifPositive3 = (num3 < 0);
        if (ifPositive1 && ifPositive2 && ifPositive3)
        {
            Console.WriteLine("Only one number is positive");
        }
        else
        {
            Console.WriteLine("Not only one");
        }
        

    }
}