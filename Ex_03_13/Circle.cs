using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_13
{

    public static double PI = 3.14;	//円周率
        int radius;	//半径
    public class Circle
    {

        public Circle(int pradius)
        {
            this.radius =pradius;
        }


        public double AreaCalculation()//フィールドの半径の値の円の面積を計算する動的メソッド
        {
            return PI*radius*radius;
        }
        public static double AreaCalculation(int pradius)//引数の半径の値の円の面積を計算する静的メソッド
        {
            return PI*pradius*pradius;
        }
    }
}