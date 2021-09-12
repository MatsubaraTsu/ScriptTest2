// Hello World プログラムを C# でRPG用に改造.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using HelloWorld;

public class Boss : BossBase
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
            }

            private const int V = 53;
            private const string V1 = "魔法攻撃をした";
            private const int V2 = 100;
            private int power = 25; // 攻撃力

            public Lesson4(int power)
            {
                this.power = power;
            }

            // mpを53で初期化する
            int hp = V;
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
            // 魔力用の関数
            internal object magic(int v)
            {

                // 残りmpを減らす
                int v1 = this.hp - hp;
                throw new NotImplementedException();
            }
        }

        internal void Defence(int v)
        {
            throw new NotImplementedException();
        }

        internal void Attack()
        {
            throw new NotImplementedException();
        }

        internal void magic(int v)
        {
            throw new NotImplementedException();
        }
    }
    public class Lesson4 : MonoBehaviour
    {
        private const int V = 53;
        private const int V1 = 5;

        void Start()
        {
            //Magic関数を 11回呼び出す
            for (int magic = 5; magic < 53; magic++)
            {
                Debug.Log(magic + "魔法攻撃をした。残りのmpは○○。");
            }

            // Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss();

            // 攻撃用の関数を呼び出す
            lastboss.Attack();
            // 防御用の関数を呼び出す
            lastboss.Defence(3);
            // 魔力用の関数を呼び出す
            lastboss.magic(V);

            //  Magic関数を1回呼び出す
            for (int magic = 5; magic < 53; magic++)
            {
                Debug.Log(magic + "MPが足りないため、魔法が使えない");
            }
        }
    }
