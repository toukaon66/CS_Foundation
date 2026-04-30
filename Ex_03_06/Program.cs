namespace Ex_03_06;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("商品番号を入力してください->");
        int itemNo = int.Parse(System.Console.ReadLine());
        System.Console.Write("商品名を入力してください->");
        string itemName = System.Console.ReadLine();
        System.Console.Write("単価を入力してください->");
        int price = int.Parse(System.Console.ReadLine());
        System.Console.Write("新しい単価を入力してください->");
        int newprice = int.Parse(System.Console.ReadLine());
        item.ChangePrice(newprice);
        Item item = new Item(itemNo, itemName, price);

        System.Console.WriteLine("結果");
        item.Print();
        System.Console.Write("更に新しい単価を入力してください->");
        int price = int.Parse(System.Console.ReadLine());  
        public void ChangePrice(pprice);
        System.Console.WriteLine("結果");
        item.Print();
    }
}
