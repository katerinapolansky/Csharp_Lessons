namespace homework4;

using System;

public class Class2
{
    static void Main()
    {
        int[] numbers = new int[5];
        Console.WriteLine("Enter 5 integers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        
        int max = numbers[0];
        int min = numbers[0];
        
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }

            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        
        Console.WriteLine($"\nMaximum value in the array: {max}");
        Console.WriteLine($"Minimum value in the array: {min}");
    }
    
    using System;

    class ReverseArray
    {
        static void Main()
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 integers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("\nArray in reverse order:");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine(); 
        }
    }
    
    
    using System;

    class AverageOfArray
    {
        static void Main()
        {
            double[] numbers = new double[10];
            double sum = 0;
            Console.WriteLine("Enter 10 floating-point numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            
            double average = sum / numbers.Length;
            Console.WriteLine($"\nThe average of the array elements is: {average}");
        }
    }

    

}
