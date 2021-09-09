// Hello World プログラムを C# でRPG用に改造.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace HelloWorld
{
    class Hello
    {
        static int hp, mp, exp_;
        static int kizugusuri_kosuu;

        static int battle()
        {
            Console.WriteLine("モンスターと戦闘中・・・  ");

            hp = hp - 5;
            Console.WriteLine("負傷したぞ！ 5のダメージ！ HPが5減った ");
            Console.WriteLine("HP = " + hp);

            Console.WriteLine("魔法攻撃をした！ 残りのMPは○○。 ");
            mp = mp - 5;
            Console.WriteLine("MP = " + mp);

            Console.WriteLine("モンスターを倒した、 経験値を2ポイント獲得した ");
            exp_ = exp_ + 2;

            return 0;
        }

        static int heal()
        {
            Console.WriteLine("傷薬で回復  \n");
            hp = hp + 3;
            Console.WriteLine("HP = " + hp);

            Console.WriteLine("傷薬が1個減った  ");
            kizugusuri_kosuu = kizugusuri_kosuu - 1;
            Console.WriteLine("傷薬は残り " + kizugusuri_kosuu + "個。");

            return 0;
        }

        static void Main()
        { 

            hp = 30; mp = 53; exp_ = 0;
            kizugusuri_kosuu = 10;

            hp = 30; mp = 25; exp_ = 0;
            kizugusuri_kosuu = 10;

            Console.WriteLine("冒険を始めた。 最初のHPは" + hp + "、MPは" + mp + "。経験値は" + exp_);

            Console.WriteLine("モンスターに遭遇した、 戦闘  ");
            battle();
            Console.WriteLine("戦闘終了後のHPは" + hp + "、残りのMPは" + mp + "。経験値は" + exp_);

            Console.WriteLine("回復アイテムを使用する  ");
            heal();
            Console.WriteLine("回復後のHPは" + hp + "。MPは" + mp + "。経験値は" + exp_);

            Console.ReadKey();
        }
    }
}
public class Boss
{
    // Use this for initialization
    void Start()
    {
        // 要素数53の配列を初期化する
        int[] points = new int[53];

        // 配列の各要素に値を代入する
        points[0] = 3;
        points[1] = 8;
        points[2] = 6;
        points[3] = 1;
        points[4] = 5;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }
    }

    private int hp = 30;          // 体力
    private int power = 25; // 攻撃力


    // mpを53で初期化する
    int Mp = 53;
    private Action<int> magic;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //魔力用の関数
    public void MP(int magic)
    {
        // 残りmpを減らす
        this.magic -= MP;
    }




public class Test : MonoBehaviour
    {

        void Start()
        {
            // Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss();

            // 攻撃用の関数を呼び出す
            lastboss.Attack();
            // 防御用の関数を呼び出す
            lastboss.Defence(5);

            // 消費前とと消費後の値を引いた値を返す関数
            int Add(int mp, int magic)
            {
                // 消費前と消費後の値を引いて、Mpに代入する
                int Mp = mp - magic;
                // 変数cを呼び出し元の関数に返す
                return Mp;

                // Add関数に「5」と「55」の引数を渡し、返り値をnum変数に代入する
                int num = Add(5, 55);
                // numを表示する
                Debug.Log(num);
            }
        }
    }
}