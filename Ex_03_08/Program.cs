namespace Ex_03_08;

static class Program
{
    static void Main(string[] args)
    {
        Netaccount netaccount=new();
        System.Console.Write("口座番号を入力してください->");
        netaccount.AccountNo = System.Console.ReadLine();
        System.Console.Write("口座名義を入力してください->");
        netaccount.AccountName = System.Console.ReadLine();
        System.Console.Write("残高を入力してください->");
        netaccount.Balance = int.Parse(System.Console.ReadLine());
        System.Console.Write("ポイントを入力してください->");
        netaccount.Point = int.Parse(System.Console.ReadLine());

        Console.WriteLine($"口座番号:{netaccount.Point}口座名義:{netaccount.AccountName}残高:{netaccount.Balance}ポイント:{netaccount.Point}");
    }
}
