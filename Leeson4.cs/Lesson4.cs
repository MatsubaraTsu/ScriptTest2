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
            Console.WriteLine("���������A 5�̃_���[�W HP��5������  ");
            Console.WriteLine("HP = " + hp);

            Console.WriteLine("���@�ōU������AMP��5����  ");
            mp = mp - 3;
            Console.WriteLine("MP = " + mp);

            Console.WriteLine("�����X�^�[��|�����A �o���l��2�|�C���g�l������");
            exp_ = exp_ + 2;

            return 0;
        }

        static int heal()
        {
            Console.WriteLine("����ŉ񕜂�  \n");
            hp = hp + 3;
            Console.WriteLine("HP = " + hp);

            Console.WriteLine("����1������  ");
            kizugusuri_kosuu = kizugusuri_kosuu - 1;
            Console.WriteLine("����͎c�� " + kizugusuri_kosuu + "�B");

            return 0;
        }

        static void Main()
        {
            hp = 30; mp = 25; exp_ = 0;
            kizugusuri_kosuu = 10;

            hp = 30; mp = 25; exp_ = 0;
            kizugusuri_kosuu = 10;

            Console.WriteLine("�`�����n�߂��A �ŏ���HP��" + hp + "�AMP��" + mp + "�B�o���l��" + exp_);

            Console.WriteLine("�����X�^�[�ɑ��������A �퓬 ");
            battle();
            Console.WriteLine("�퓬�I�����HP��" + hp + "�A�c��MP��" + mp + "�B�o���l��" + exp_);

            Console.WriteLine("�񕜃A�C�e�����g�p����  ");
            heal();
            Console.WriteLine("�񕜌��HP��" + hp + "�B�c��MP��" + mp + "�B�o���l��" + exp_);

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
                // �v�f��5�̔z�������������
                int[] arriy = new int[5];

                // �z��̊e�v�f�ɒl��������
                arriy[0] = 3;
                arriy[1] = 8;
                arriy[2] = 6;
                arriy[3] = 1;
                arriy[4] = 5;

                // �z��̗v�f�����ׂĕ\������
                for (int i = 0; i < 5; i++)
                {
                    Debug.Log(arriy[i]);
                }
                for (int b = 4; b < 5; b--)
                {
                    Debug.Log(arriy[b]);
                }
            }

            // ����O�ƂƏ����̒l���������l��Ԃ��֐�
            int Add(int mp, int magic)
            {
                // ����O�Ə����̒l�������āAMp�ɑ������
                int Mp = mp - magic;
                // �ϐ�c���Ăяo�����̊֐��ɕԂ�
                return Mp;

                // Add�֐��Ɂu5�v�Ɓu53�v�̈�����n���A�Ԃ�l��num�ϐ��ɑ������
                int num = Add(5, 53);
                // num��\������
                Debug.Log(num);
            }

            private const int V = 53;
            private const string V1 = "���@�U��������";
            private int hp = 100;          // �̗�
            private int power = 25; // �U����

            // mp��53�ŏ���������
            int mp = V;
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
                this.mp -= damage;
            }
            // ���͗p�̊֐�
            internal object magic(int v)
            {

                // �c��mp�����炷
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
            // ���͗p�̊֐����Ăяo��
            lastboss.magic(V);

            // 1�񏈗����J��Ԃ�
            for (int magic = 5; magic < 5; magic++)
            {
                Debug.Log(magic + "MP������Ȃ����߁A���@���g���Ȃ�");
            }
        }
    }
}