// Hello World �v���O������ C# ��RPG�p�ɉ���.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boss
{
    // Use this for initialization
    void Start()
    {
        // �v�f��5�̔z�������������
        int[] points = new int[53];

        // �z��̊e�v�f�ɒl��������
        points[0] = 3;
        points[1] = 8;
        points[2] = 6;
        points[3] = 1;
        points[4] = 5;

        // �z��̗v�f�����ׂĕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }
    }

    private int hp = 30;          // �̗�
    private int power = 25; // �U����


    // mp��53�ŏ���������
    int Mp = 53;
    private Action<int> magic;

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

    //���͗p�̊֐�
    public void MP(int magic)
    {
        // �c��mp�����炷
        this.magic -= MP;
    }




public class Test : MonoBehaviour
    {

        void Start()
        {
            // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
            Boss lastboss = new Boss();

            // �U���p�̊֐����Ăяo��
            lastboss.Attack();
            // �h��p�̊֐����Ăяo��
            lastboss.Defence(5);

            // ����O�ƂƏ����̒l���������l��Ԃ��֐�
            int Add(int mp, int magic)
            {
                // ����O�Ə����̒l�������āAMp�ɑ������
                int Mp = mp - magic;
                // �ϐ�c���Ăяo�����̊֐��ɕԂ�
                return Mp;

                // Add�֐��Ɂu5�v�Ɓu55�v�̈�����n���A�Ԃ�l��num�ϐ��ɑ������
                int num = Add(5, 55);
                // num��\������
                Debug.Log(num);
            }
        }
    }

    private void Attack()
    {
        throw new NotImplementedException();
    }
}