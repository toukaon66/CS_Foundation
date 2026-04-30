namespace Ex_03_06;

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
        System.Console.Write("新しい単価を入力してください->");
        int newprice = int.Parse(System.Console.ReadLine());
        item.ChangePrice(newprice);
        

        System.Console.WriteLine("結果");
        item.Print();
        System.Console.Write("更に新しい単価を入力してください->");
        //int pprice = int.Parse(System.Console.ReadLine());  
        item.ChangePrice(System.Console.ReadLine());
        System.Console.WriteLine("結果");
        item.Print();
    }
}
