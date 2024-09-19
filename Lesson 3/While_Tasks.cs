namespace Lesson_3;

public class While_Tasks
{
    public void While3()
    {
        Console.Write("Write n: ");
        var n = int.Parse(Console.ReadLine());

        Console.Write("Write k: ");
        var k = int.Parse(Console.ReadLine());
        

        while (n>k)
        {
            n -= k;
            
        }
        Console.WriteLine(n);
        
        
    }
}