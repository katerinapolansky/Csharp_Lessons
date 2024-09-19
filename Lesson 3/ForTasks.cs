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
}
