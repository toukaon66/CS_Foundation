namespace Ex_03_03;

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

        System.Console.Write("新しい単価を入力してください->");
        int newprice = int.Parse(System.Console.ReadLine());

        ChangePrice();
        /* public void ChangePrice(int newprice)
         {price=newprice;}
         ChangePrice();現在「ChangePrice」という名前は存在しない*/
        System.Console.WriteLine("結果");
        item.Print();
    }
}
