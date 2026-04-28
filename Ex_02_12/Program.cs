using System.ComponentModel;

namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値を入力してください->");
       int number = int.Parse(System.Console.ReadLine());

        int hyouzi =Mul3(number);
        Console.WriteLine(hyouzi);

        int Mul3(int y)
        {
            return y*3;
        }

    }
}
