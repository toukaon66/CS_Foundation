namespace Ex_03_02;

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
        //Printをよびふぁしたい
         item.Print();



        // void  itemNo= item.GetitemNo();
        //  Console.WriteLine($"item.itemNo");
        // void itemName = item.itemName();
        // Console.WriteLine($"item.itemName");
        // int price = item.price();
        // Console.WriteLine($"item.price");
        
        
        
    //      Console.Write("値を入力してください->");
    //    int number = int.Parse(System.Console.ReadLine());

    //     int hyouzi =Mul3(number);
    //     Console.WriteLine(hyouzi);

    //     int Mul3(int y)
    //     {
    //         return y*3;
    }
}
