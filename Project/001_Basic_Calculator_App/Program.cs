using System.Security.Cryptography.X509Certificates;

public class Program
{

    public static void Main(string[] args)
    {
        int number1,number2, total, selected;
        Console.Write ("Please insert a number : ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write ("Please insert a number : ");
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Select a number 1(+), 2(-), 3(*), 4(/) : ");
        selected = Convert.ToInt32(Console.ReadLine());
        switch (selected)
        {
            case 1:
                total = Add(number1,number2);
            break;
            case 2:
                total = Subs(number1,number2);
            break;
            case 3:
                total = Multiply(number1,number2);
            break;
            case 4:
                total = Divide(number1, number2);
            break;

            default :
            total =1;
            break;
        }
        Console.WriteLine ("Total : "+total);
        Console.ReadKey();
    }
    public static int Add(int n1, int n2)
    {
        int t = n1 + n2;
        return t;

    }
     public static int Subs(int n1, int n2)
    {
        int t = n1 - n2;
        return t;

    }
     public static int Multiply(int n1, int n2)
    {
        int t = n1 * n2;
        return t;

    }
     public static int Divide(int n1, int n2)
    {
        int t = n1 / n2;
        return t;

    }
}