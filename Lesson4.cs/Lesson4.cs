// Hello World �v���O������ C# ��RPG�p�ɉ���.
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
            }

            private const int V = 53;
            private const string V1 = "���@�U��������";
            private const int V2 = 100;
            private int power = 25; // �U����

            public Lesson4(int power)
            {
                this.power = power;
            }

            // mp��53�ŏ���������
            int hp = V;
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
            // ���͗p�̊֐�
            internal object magic(int v)
            {

                // �c��mp�����炷
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
            //Magic�֐��� 11��Ăяo��
            for (int magic = 5; magic < 53; magic++)
            {
                Debug.Log(magic + "���@�U���������B�c���mp�́����B");
            }

            // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
            Boss lastboss = new Boss();

            // �U���p�̊֐����Ăяo��
            lastboss.Attack();
            // �h��p�̊֐����Ăяo��
            lastboss.Defence(3);
            // ���͗p�̊֐����Ăяo��
            lastboss.magic(V);

            //  Magic�֐���1��Ăяo��
            for (int magic = 5; magic < 53; magic++)
            {
                Debug.Log(magic + "MP������Ȃ����߁A���@���g���Ȃ�");
            }
        }
    }
