using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力

    // mpを53で初期化する
    int mp = 53;

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

    // 魔法攻撃用の関数
    public void magic(int magic)
    {
        Debug.Log(magic + "魔法攻撃をした。残りMPは○○。");
    }
    public class Lesson4 : MonoBehaviour
    {
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

            // 1回処理を繰り返す
            for (int magic = 5; magic < 5; magic++)
            {
                Debug.Log(magic + "MPが足りないため、魔法が使えない");
            }
        }
        // Update is called once per frame
        void Update()
        {
            // Lesson4.cs
            //comppile with: /target:library
        }
    }
}