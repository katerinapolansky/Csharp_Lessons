using System.Linq.Expressions;

namespace Lesson2;

public class Practice
{
    public void ConvertString()
    {
        string str = "I learn c#" + Math.PI;
        Console.WriteLine(str);
    }

    public void Convert2()
    {
        short mal = 300;
        int newby = Convert.ToInt32(mal);
        Console.WriteLine(newby);
    }

    public void UserFlow()
    {
        var userData = Console.ReadLine();
        bool isParsed = int.TryParse(userData, out int num);
        Console.WriteLine(num);
        if (isParsed)
        {
            Console.WriteLine($"The result is {num}");
        }
        else
        {
            Console.WriteLine("Couldn't parse");
        }
            

    }

}

