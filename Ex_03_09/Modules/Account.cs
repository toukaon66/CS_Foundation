namespace Ex_03_09;

public class Account
{
public string? AccountNo { get; set; }	//口座番号を表すプロパティ
public string? AccountName { get; set; }	//口座名義を表すプロパティ
public int Balance { get; set; }	//残高を表すプロパティ



public Account(string AccountNo, string AccountName, int Balance)
    {
        this.AccountNo = AccountNo;
        this.AccountName = AccountName;
        this.Balance = Balance;

    }
        public virtual void Print()
    {
        System.Console.WriteLine($"口座番号＝{AccountNo}");
        System.Console.WriteLine($"口座名義{AccountName}");
        System.Console.WriteLine($"残高＝{Balance}");
    }



}