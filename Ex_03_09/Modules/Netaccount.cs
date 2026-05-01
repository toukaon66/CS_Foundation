namespace Ex_03_09;

public class NetAccount : Account
{
    
         public int Point { get; set; }	//ポイントを表すプロパティ
    

public NetAccount(string AccountNo, string AccountName, int Balance, int Point)
: base(AccountNo, AccountName, Balance)
    {
        this.Point = Point;
    }

public override void Print()
    {
        Console.WriteLine($"ポイント={Point}");
        base.Print();
    }
}