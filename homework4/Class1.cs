namespace homework4;

public class Cycles
{
    static void MultiplicationTable()
    {
        
        for (int i = 1; i <= 5; i++)
        {
            
            for (int j = 1; j <= 5; j++)
            {
                
                Console.Write((i * j).ToString().PadLeft(4));
            }

          
            Console.WriteLine();
        }
    }

    

    static void TriangleOfStarsain()
    {
       
        Console.Write("Number of rows for the triangle: ");
        int rows = int.Parse(Console.ReadLine());

        
        for (int i = 1; i <= rows; i++)
        {
            
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            
            Console.WriteLine();
        }
    }
    
    
}