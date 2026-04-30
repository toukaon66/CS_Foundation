namespace Ex_03_06;

/// <summary>
/// 商品情報を表すクラス
/// </summary>

public class Item
{

    public int itemNo; //商品番号
    public string itemName; //商品名
    public int price; //単価


  
    public void Print()
    {
        System.Console.WriteLine($"商品番号＝{itemNo}");
        System.Console.WriteLine($"商品名＝{itemName}");
        System.Console.WriteLine($"価格＝{price}");
    }
       
    public void ChangePrice(int price)
    {
        this.price = price;
    }

    public void ChangePrice(string pprice)
    {
        int price = int.Parse(pprice);
        this.price = price;
    }


public Item(int pitemNo,string pitemName,int pprice)
    {
        itemNo = pitemNo;
        itemName = pitemName;
        price = pprice;
    }
}