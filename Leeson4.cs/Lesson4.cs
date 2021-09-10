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
            Console.WriteLine("負傷した、 5のダメージ HPが5減った  ");
            Console.WriteLine("HP = " + hp);

            Console.WriteLine("魔法で攻撃する、MPが5減る  ");
            mp = mp - 3;
            Console.WriteLine("MP = " + mp);

            Console.WriteLine("モンスターを倒した、 経験値を2ポイント獲得した");
            exp_ = exp_ + 2;

            return 0;
        }

        static int heal()
        {
            Console.WriteLine("傷薬で回復だ  \n");
            hp = hp + 3;
            Console.WriteLine("HP = " + hp);

            Console.WriteLine("傷薬が1個減った  ");
            kizugusuri_kosuu = kizugusuri_kosuu - 1;
            Console.WriteLine("傷薬は残り " + kizugusuri_kosuu + "個。");

            return 0;
        }

        static void Main()
        {
            hp = 30; mp = 25; exp_ = 0;
            kizugusuri_kosuu = 10;

            hp = 30; mp = 25; exp_ = 0;
            kizugusuri_kosuu = 10;

            Console.WriteLine("冒険を始めた、 最初のHPは" + hp + "、MPは" + mp + "。経験値は" + exp_);

            Console.WriteLine("モンスターに遭遇した、 戦闘 ");
            battle();
            Console.WriteLine("戦闘終了後のHPは" + hp + "、残りMPは" + mp + "。経験値は" + exp_);

            Console.WriteLine("回復アイテムを使用する  ");
            heal();
            Console.WriteLine("回復後のHPは" + hp + "。残りMPは" + mp + "。経験値は" + exp_);

            Console.ReadKey();
        }
    }
    public class Boss
    {

        public class Lesson4 : MonoBehaviour
        {
            // Use this for initialization
            void Start()
            {
                // 要素数5の配列を初期化する
                int[] arriy = new int[5];

                // 配列の各要素に値を代入する
                arriy[0] = 3;
                arriy[1] = 8;
                arriy[2] = 6;
                arriy[3] = 1;
                arriy[4] = 5;

                // 配列の要素をすべて表示する
                for (int i = 0; i < 5; i++)
                {
                    Debug.Log(arriy[i]);
                }
                for (int b = 4; b < 5; b--)
                {
                    Debug.Log(arriy[b]);
                }
            }

            // 消費前とと消費後の値を引いた値を返す関数
            int Add(int mp, int magic)
            {
                // 消費前と消費後の値を引いて、Mpに代入する
                int Mp = mp - magic;
                // 変数cを呼び出し元の関数に返す
                return Mp;

                // Add関数に「5」と「53」の引数を渡し、返り値をnum変数に代入する
                int num = Add(5, 53);
                // numを表示する
                Debug.Log(num);
            }

            private const int V = 53;
            private const string V1 = "魔法攻撃をした";
            private int hp = 100;          // 体力
            private int power = 25; // 攻撃力

            // mpを53で初期化する
            int mp = V;
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
                this.mp -= damage;
            }
            // 魔力用の関数
            internal object magic(int v)
            {

                // 残りmpを減らす
                int v1 = this.mp - mp;
                throw new NotImplementedException();
            }
        }

        internal void magic(int v)
        {
            throw new NotImplementedException();
        }

        internal void Defence(int v)
        {
            throw new NotImplementedException();
        }

        internal void Attack()
        {
            throw new NotImplementedException();
        }
    }
    public class Lesson4 : MonoBehaviour
    {
        private const int V = 53;

        void Start()
        {
            // 10回繰り返す
            for (int magic = 5; magic < 5; magic++)
            {
                Debug.Log(magic);
            }

            // Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss();

            // 攻撃用の関数を呼び出す
            lastboss.Attack();
            // 防御用の関数を呼び出す
            lastboss.Defence(3);
            // 魔力用の関数を呼び出す
            lastboss.magic(V);

            // 1回処理を繰り返す
            for (int magic = 5; magic < 5; magic++)
            {
                Debug.Log(magic + "MPが足りないため、魔法が使えない");
            }
        }
    }
}