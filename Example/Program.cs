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

        // int a = 5;
        // int b = 2;
        // float c = (float)a / b;
        //一時的に型変換　より精度が高い（細かい数字）ほうが優先される　同じ演算型だと同じ演算型の結果しか出ない
        //今回の場合（float）aがないときはint（整数）だから小数点以下が出なくなる
        // System.Console.WriteLine(c);*/

        /*const double TAX_RATE = 10.0;//OK
        const double TAX_RATE ;
        TAX_RATE=10.0;//行を変えての宣言はできない*/

        //System.Console.Write(c);

        // 数値の演算
        /*Console.WriteLine($"10 + 3 = {10 + 3}");
        Console.WriteLine($"10 - 3 = {10 - 3}");
        Console.WriteLine($"10 * 3 = {10 * 3}");
        Console.WriteLine($"10 / 3 = {10 / 3}");
        Console.WriteLine($"10 % 3 = {10 % 3}");
        // 文字列の連結
        Console.WriteLine($"ABC + XYZ = {"ABC" + "XYZ"}");
        // 文字列と他のデータ型の結合
        Console.WriteLine($"ABC + 1 = {"ABC" + 1}");
        // その他、文字列の結合と表示（参考）
        Console.WriteLine($"ABC + 2 = {"ABC"}{2}");
        Console.WriteLine("ABC + 3 = {0}{1}", "ABC", 3);*/
        // 数値の演算
        /*int a = 10;
        Console.WriteLine($"a += 3 -> {a += 3}");
        Console.WriteLine($"a -= 3 -> {a -= 3}");
        Console.WriteLine($"a *= 3 -> {a *= 3}");
        Console.WriteLine($"a /= 3 -> {a /= 3}");
        Console.WriteLine($"a %= 3 -> {a %= 3}");
        // 文字列の連結
        string b = "ABC";
        Console.WriteLine($"b += XYZ -> {b += "XYZ"}");
        // 文字列と他のデータ型の結合
        string c = "LMN";
        Console.WriteLine($"c += 1   -> {c += 1}");*/

        /*var a = 10;
        // インクリメント
        a++;
        Console.WriteLine($"a++ -> {a}");
        // ディクリメント
        a--;
        Console.WriteLine($"a-- -> {a}");
        // 符号の反転、正負の反転
        a = -a;
        Console.WriteLine($"-a  -> {a}");
        // ビットの反転、1の補数
        a = ~a;
        Console.WriteLine($"~a  -> {a}");*/

        /*var a = 10;
        Console.WriteLine($"a == 10 -> {a == 10}");
        Console.WriteLine($"a == 20 -> {a == 20}");
        Console.WriteLine($"a != 10 -> {a != 10}");
        Console.WriteLine($"a != 20 -> {a != 20}");
        var s = "World";
        Console.WriteLine($"s == Hello -> {s == "Hello"}");
        Console.WriteLine($"s != Hello -> {s != "Hello"}");*/
        /*var a = 10;
        Console.WriteLine($"a < 10  -> {a < 10}");
        Console.WriteLine($"a < 20  -> {a < 20}");
        Console.WriteLine($"a <  0  -> {a < 0}");
        Console.WriteLine($"a > 10  -> {a > 10}");
        Console.WriteLine($"a > 20  -> {a > 20}");
        Console.WriteLine($"a >  0  -> {a > 0}");
        Console.WriteLine($"a <= 10 -> {a <= 10}");
        Console.WriteLine($"a <= 20 -> {a <= 20}");
        Console.WriteLine($"a <=  0 -> {a <= 0}");
        Console.WriteLine($"a >= 10 -> {a >= 10}");
        Console.WriteLine($"a >= 20 -> {a >= 20}");
        Console.WriteLine($"a >=  0 -> {a >= 0}");*/
        /* bool a = true, b = false;
        Console.WriteLine($"a && a = {a && a}");
        Console.WriteLine($"a && b = {a && b}");
        Console.WriteLine($"b && a = {b && a}");
        Console.WriteLine($"b && b = {b && b}");
        Console.WriteLine($"a || a = {a || a}");
        Console.WriteLine($"a || b = {a || b}");
        Console.WriteLine($"b || a = {b || a}");
        Console.WriteLine($"b || b = {b || b}");
        int x = 1;
        Console.WriteLine($"b && x++ > 1 = {b && x++ > 1}");
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"b & x++ > 1 = {b & x++ > 1}");
        Console.WriteLine($"x = {x}");*/

        /*var count = 1;
        while (count < 8)
        {
            count *= 2;
            Console.WriteLine($"count *= {count}");
        }*/

        /*for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{i}月です");
        }*/

        /*for (int i = 2; i <= 3; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine($"{i} + {j} = {i + j}");
            }
        }
        Console.WriteLine("終了");*/
        /*int i = 0;
        while (i < 10)
        {
            if (i == 5)
            {
                break;
            }
            Console.WriteLine($"i = {i}");
            i++;
        }
        Console.WriteLine("終了");*/
        /*for (int i = 0; i < 6; i++)
        {
            if (i == 2)
            {
                continue;
            }
            Console.WriteLine($"i = {i}");
        }
        Console.WriteLine("終了");*/

        /*PrintHello();

        int answer = Add(4, 5);
        Console.WriteLine(answer);

        void PrintHello()
        {
            Console.WriteLine("Hello, World!");
        }

        int Add(int x, int y)
        {
            return x + y;
        }*/

        /*string day = "本日";
string wether = "晴れ";
// 可変数の引数を渡せる
StringConcatenation(day, "は", wether, "です。");
/// <summary>
/// 引数の文字列を結合して表示する
/// </summary>
/// <param name="strings">結合する文字列</param>
static void StringConcatenation(params string[] strings)
{
    var result = "";
    for (int i = 0; i < strings.Length; i++)
    {
        result += strings[i];
    }
    Console.WriteLine(result);
}*/

        /*namespace Example;

        // インスタンスの生成
        Warrior warrior = new();
        Monster monster = new();
        // フィールドに値を設定
        warrior.name = "ユータ";
        monster.name = "ゴブ";
        // メソッドの利用
        string meter1 = warrior.GetHpMeter();// 初期の戦士のHPを取得
        Console.WriteLine(meter1); // 戦士のHPを表示
        monster.Attack(warrior); // 魔物が戦士に攻撃
        string meter2 = warrior.GetHpMeter();// 攻撃を受けた後の戦士のHPを取得
        Console.WriteLine(meter2); // 戦士のHPを表示*/

        // Warrior warrior = null;
        // Console.WriteLine($"warrior={warrior}");
        // warrior.Greet();//cはnullなのでエラー

        /*Warrior warrior = new("ユータ", 15);
        Console.WriteLine(warrior.name);
        Console.WriteLine(warrior.hp);

        Warrior warrior2= new();
        warrior2.name="ユースケ";
        warrior2.hp=8;

        Warrior warrior3= new("コースケ",8);
        Console.WriteLine(warrior3.name);
        Console.WriteLine(warrior3.hp);

        // Console.WriteLine(warrior2.name);*/

        // Warrior warrior = new Warrior();

        // warrior.name = "ユータ";
        // warrior.hp = 10;// 別なクラスから見えないのでコンパイルエラーになる

        // warrior.Greet1();
        // warrior.Greet2();// 別なクラスから見えないのでコンパイルエラーになる

        // Warrior character = new();
        // character.Name = "戦士";
        // character.Hp = 10;//setアクセッサがprivateなので設定不可
        // character.Ap = 10;//読み取り専用プロパティなので設定不可


        // var warrior = new Warrior();
        // warrior.Name = "戦士";
        // warrior.Greet();

       try
{
    int[] vals = null;
    ArrayCalc arrayCalc = new ArrayCalc();
    var sum = arrayCalc.Summarize(vals);
    Console.WriteLine($"合計={0}", sum);
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("配列の誤ったアクセスによる例外");
}
catch (NullReferenceException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("値がNullの変数利用による例外");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("その他の例外");
}
    }
}