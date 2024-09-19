namespace Lesson_3;

public class Practice3
{
    public void Switch()
    {
        Console.Write("Write a number : ");
        var userInput = Console.ReadLine();

        var isUserInputCorrect = int.TryParse(userInput, out var userInputInt);

        switch (userInputInt)
        {
            case 0: 
                {
                    Console.WriteLine("0");
                    break;
                }
            case 1: { Console.WriteLine("1"); break; }
            case 2: { Console.WriteLine("2"); break; }
            case 3: { Console.WriteLine("3"); break; }
            case 4: { Console.WriteLine("4"); break; }
            case 5: { Console.WriteLine("5"); break; }
            case 6: { Console.WriteLine("6"); break; }
            case 7: { Console.WriteLine("7"); break; }
            default:
                Console.WriteLine("not match");
                break;
        }
    }
}