using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����

    // mp��53�ŏ���������
    int mp = 53;

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    // ���@�U���p�̊֐�
    public void magic(int magic)
    {
        Debug.Log(magic + "���@�U���������B�c��MP�́����B");
    }
    public class Lesson4 : MonoBehaviour
    {
        void Start()
        {
            // 10��J��Ԃ�
            for (int magic = 5; magic < 5; magic++)
            {
                Debug.Log(magic);
            }

            // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
            Boss lastboss = new Boss();

            // �U���p�̊֐����Ăяo��
            lastboss.Attack();
            // �h��p�̊֐����Ăяo��
            lastboss.Defence(3);

            // 1�񏈗����J��Ԃ�
            for (int magic = 5; magic < 5; magic++)
            {
                Debug.Log(magic + "MP������Ȃ����߁A���@���g���Ȃ�");
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