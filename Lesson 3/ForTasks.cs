using System.Globalization;

namespace Lesson_3;

public class ForTasks
{
    public void For1Task()
    {
        Console.Write("Write n : ");
        var n = int.Parse(Console.ReadLine());

        Console.Write("Write n : ");
        var k = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(k);
        }
    }

    public void For2Task()
    {
        Console.Write("Write a : ");
        var a = int.Parse(Console.ReadLine());

        Console.Write("Write b : ");
        var b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(b-a+1);
        }
        
    }
    
    public void For7Task()
    {
        Console.Write("Write a : ");
        var a = int.Parse(Console.ReadLine());

        Console.Write("Write b : ");
        var b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            var numbers = new List<int>();
           
            for (int i = a; i <= b; i++)
            {
               
                numbers.Add(i);
                
                
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        
    }
    
}
