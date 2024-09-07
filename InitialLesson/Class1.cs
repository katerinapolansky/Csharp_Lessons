using System.ComponentModel.Design;

namespace InitialLesson;

public class Class1
{
    public string Envvar = "a";

    public Class1()
    {

    }

    public void From1To30()
    {
        var letter = new Letter()
        {
            Type = null,
            Recipient = "Katya"
        };

        var str = $"Recipient = {letter.Recipient}";

        var firstNum = 15;

        var sms = $"Hi! Would you like to have a lesson from {firstNum} pm to 12 pm according to ukrainian time zone\r\nfrom 10 to 11 it is programing lesson and then english, Best Regards {letter.Recipient}";
        Console.WriteLine(sms);
        //for (int i = 1; i < 31; i++) 
        //{
        //    Console.WriteLine(i);
        //}
    }

    public void Convertation()
    {
        var i = 0;
        var katya = 1;
        if (false)
        {
            katya = 0;
        }

        Console.WriteLine(--i);

        int a = 123000;
        double d = a;

        var result = Math.Pow(d, 10);

       // byte b = Convert.ToByte(a);

        short s1 = 260;

        byte b1 = (byte)s1;
        Console.WriteLine(b1);

        byte b2 = Convert.ToByte(s1);
    }
}

class Letter 
{
    public string Recipient { get; set; }
    public TypeOfLetter? Type { get; set; }
}

enum TypeOfLetter
{
    RestorePassword,
    Birthday
}