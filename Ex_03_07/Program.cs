 using Ex_03_07.Modules;

namespace Ex_03_07;

static class Program
{
    static void Main(string[] args)
    {
         Item item = new();
        System.Console.Write("商品番号を入力してください->");
        item.itemNo = int.Parse(System.Console.ReadLine());
        System.Console.Write("商品名を入力してください->");
        item.itemName = System.Console.ReadLine();
        System.Console.Write("単価を入力してください->");
        item.price = int.Parse(System.Console.ReadLine());
        
        System.Console.WriteLine("結果");
        item.Print();
       
    }
}
