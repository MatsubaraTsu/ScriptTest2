// Hello World プログラムを C# でRPG用に改造.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boss
{
    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
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

    private void Attack()
    {
        throw new NotImplementedException();
    }
}