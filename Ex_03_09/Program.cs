using Ex_03_09.Modules;
namespace Ex_03_09;

static class Program
{
    static void Main(string[] args)
    {

         
        System.Console.Write("口座番号を入力してください->");
        string AccountNo = System.Console.ReadLine();
        System.Console.Write("口座名義を入力してください->");
        string AccountName = System.Console.ReadLine();
        System.Console.Write("残高を入力してください->");
        int Balance = int.Parse(System.Console.ReadLine());
        System.Console.Write("ポイントを入力してください->");
        int Point = int.Parse(System.Console.ReadLine());
        System.Console.Write("結果");
        Netaccount netaccount=new Netaccount(AccountNo,AccountName,Balance,Point);
        netaccount.Print();
    }
}
