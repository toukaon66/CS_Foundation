using System.Security.Cryptography;

namespace Ex_03_15;

static class Program
{
    static void Main(string[] args)
    {
        try
        {
        System.Console.Write("値1を入力してください->");
        int NO1 = int.Parse(System.Console.ReadLine());
        System.Console.Write("値2を入力してください->");
        int NO2 = int.Parse(System.Console.ReadLine());
        Calculator calculator=new();
        calculator.Div(NO1,NO2);
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
