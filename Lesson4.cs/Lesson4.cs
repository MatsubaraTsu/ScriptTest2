using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{

    private int hp = 100;          // �̗�
    private int power = 25; // �U����

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

}

public class Lesson4 : MonoBehaviour
{

    void Start()
    {
        // �v�f��5�̔z�������������
        int[] array = new int[5];

        // �z��̊e�v�f�ɒl��������
        array[0] = 3;
        array[1] = 8;
        array[2] = 6;
        array[3] = 1;
        array[4] = 5;

        // �z��̗v�f�����ׂĕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int b = 4; b > -1; b--)
        {
            Debug.Log(array[b]);
        }
        // Use this for initialization

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
