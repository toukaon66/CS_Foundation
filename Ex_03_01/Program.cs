using System.Net.ServerSentEvents;

namespace Ex_03_01;

static class Program
{
    static void Main(string[] args)
    {
        Item item = new Item();
        System.Console.Write("商品番号を入力してください->");
        item.itemNo = int.Parse(System.Console.ReadLine());
        System.Console.Write("商品名を入力してください->");
        item.itemName = System.Console.ReadLine();
        System.Console.Write("単価を入力してください->");
        item.price = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("結果");
        System.Console.WriteLine($"商品番号={item.itemNo}");
        System.Console.WriteLine($"商品名={item.itemName}");
        System.Console.WriteLine($"単価={item.price}");


        //         Item item = new Item();
        // Console.Write("商品番号を入力してください->");
        // item.itemNo = int.Parse(Console.ReadLine());
        // Console.Write("商品名を入力してください->");
        // item.itemName = Console.ReadLine();
        // Console.Write("単価を入力してください->");
        // item.price = int.Parse(Console.ReadLine());
        // Console.WriteLine("結果");
        // Console.WriteLine($"商品番号={item.itemNo}");
        // Console.WriteLine($"商品名={item.itemName}");
        // Console.WriteLine($"単価={item.price}");

    }

}
