namespace Ex_03_07.Modules;

/// <summary>
/// 商品情報を表すクラス
/// </summary>

public class Item
{

    public int itemNo {get;set;} //商品番号
    public string itemName{get;set;}//商品名
    public int price{get;set;} //単価



    public void Print()
    {
        System.Console.WriteLine($"商品番号＝{itemNo}");
        System.Console.WriteLine($"商品名＝{itemName}");
        System.Console.WriteLine($"価格＝{price}");
    }

    // public void ChangePrice(int price)
    // {
    //     this.price = price;
    // }

    // public void ChangePrice(string pprice)
    // {
    //     int price = int.Parse(pprice);
    //     this.price = price;
    // }


}