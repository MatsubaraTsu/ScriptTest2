// Hello World �v���O������ C# ��RPG�p�ɉ���.

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
            Console.WriteLine("�����X�^�[�Ɛ퓬���E�E�E  ");

            hp = hp - 5;
            Console.WriteLine("�����������I 5�̃_���[�W�I HP��5������ ");
            Console.WriteLine("HP = " + hp);

            Console.WriteLine("���@�U���������I �c���MP�́����B ");
            mp = mp - 5;
            Console.WriteLine("MP = " + mp);

            Console.WriteLine("�����X�^�[��|�����A �o���l��2�|�C���g�l������ ");
            exp_ = exp_ + 2;

            return 0;
        }

        static int heal()
        {
            Console.WriteLine("����ŉ�  \n");
            hp = hp + 3;
            Console.WriteLine("HP = " + hp);

            Console.WriteLine("����1������  ");
            kizugusuri_kosuu = kizugusuri_kosuu - 1;
            Console.WriteLine("����͎c�� " + kizugusuri_kosuu + "�B");

            return 0;
        }

        static void Main()
        { 

            hp = 30; mp = 53; exp_ = 0;
            kizugusuri_kosuu = 10;

            hp = 30; mp = 25; exp_ = 0;
            kizugusuri_kosuu = 10;

            Console.WriteLine("�`�����n�߂��B �ŏ���HP��" + hp + "�AMP��" + mp + "�B�o���l��" + exp_);

            Console.WriteLine("�����X�^�[�ɑ��������A �퓬  ");
            battle();
            Console.WriteLine("�퓬�I�����HP��" + hp + "�A�c���MP��" + mp + "�B�o���l��" + exp_);

            Console.WriteLine("�񕜃A�C�e�����g�p����  ");
            heal();
            Console.WriteLine("�񕜌��HP��" + hp + "�BMP��" + mp + "�B�o���l��" + exp_);

            Console.ReadKey();
        }
    }
}
public class Boss
{
    // Use this for initialization
    void Start()
    {
        // �v�f��53�̔z�������������
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
}