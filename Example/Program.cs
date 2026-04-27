namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        /*int quantity=0;
        int price=0;
        int total=quantity*price;
        System.Console.WriteLine(total);*/

        /*string a;
        a = "abcかきくけこ";
        System.Console.WriteLine(a);
        string b;
        //変数bに変数aの内容"abcあいうえお"という文字列を格納
        b = $"変数aの内容は{a}";
        System.Console.WriteLine(b);

        string c;
        //空文字列は""で表す
        c = "";
        System.Console.WriteLine(c);*/

        // int a=10;
        // a = a + 100;
        // System.Console.WriteLine(a);

        int a = 5;
        int b = 2;
        float c = (float)a / b;
        //一時的に型変換　より精度が高い（細かい数字）ほうが優先される　同じ演算型だと同じ演算型の結果しか出ない
        //今回の場合（float）aがないときはint（整数）だから小数点以下が出なくなる
        // System.Console.WriteLine(c);*/

        /*const double TAX_RATE = 10.0;//OK
        const double TAX_RATE ;
        TAX_RATE=10.0;//行を変えての宣言はできない*/

        //System.Console.Write(c);
    }
}