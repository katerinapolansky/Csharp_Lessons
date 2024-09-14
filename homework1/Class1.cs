using System.Globalization;
using System.Linq.Expressions;

namespace HW1;

public class Homework1
{
    public void BasicDataTypes()
    {
        int age = 25;
        double price = 99.99;
        char firstLetter = 'J';
        bool likesProgramming = true;
        string fullName = "John Doe";

        Console.WriteLine(
            $"Age: {age}\nPrice: {price}\nFirst Letter of Name: {firstLetter}\nLikes Programming: {likesProgramming}\nFull Name: {fullName}");
    }

    public void TypeConversion()
    {
        double x = 111.111;
        int convertedDouble = Convert.ToInt32(x);
        Console.WriteLine(convertedDouble);
        
        int myAge = 26;
        string a = Convert.ToString(myAge);
        Console.WriteLine($"I am {myAge}");
        
        string myStr = "200";
        int d = int.Parse(myStr);

        int h;
        string myStr2 = "200";
        bool p = int.TryParse(myStr2, out h);
        
    }

    public void Strings()
    {
        string goal = "I am a QA automation";
        string upperString = goal.ToUpper();
        Console.WriteLine(upperString);
        
        Console.WriteLine(upperString.Length);
        
        string result = goal.Substring(0,5);
        Console.WriteLine(result);

        string n = goal.Replace("QA", "Senior QA");
        Console.WriteLine(n);

    }

    public void StringInterpolation()
    {
        string name = "Kate";
        string lastName = "Polianska";
        string age = "26";
        string str = $"My full name is: {name} {lastName}. My age is {age}";
        Console.WriteLine(str);
        
    }

    public void StringFormatting()
    {
        double price = 9.99;
        string newPrice = "£" + price.ToString("N2");
        Console.WriteLine(newPrice);

        var time = DateTime.Today;
        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
        Console.WriteLine(DateTime.Now.ToString("M/d/yyyy"));
        Console.WriteLine(DateTime.Now.ToString("dddd"));
        
    }

    public void CustomStringFormatting()
    {
        double a = 1.0056;                                                                 //Declare a double variable for a number.
        Console.WriteLine(a.ToString("P", CultureInfo.InvariantCulture));            //Format the double as a percentage.

                                                                       //Declare an int variable and format it as hexadecimal.
        int number = 255;        
        string hexString = number.ToString("X");
        Console.WriteLine(hexString);
    }

}
    