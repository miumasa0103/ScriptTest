using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 50; //�̗�
    private int power = 10; //�U����
    private int mp = 53; //���̗͂�
    //�U���̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");

    }

    //�h��̊֐�
    public void Deffence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");

        this.hp -= damage;


    }

    //���@�̊֐�
    public void Magic(int cost)
    {
        while(this.mp>=5)                 //MP��5�ɂȂ�܂ŁA�J��Ԃ�MP����
        {
            this.mp -= cost;
        
            Debug.Log("���@�U���������B�c��MP��" + this.mp);

         }
          
           
        Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");

     }
}

public class Test : MonoBehaviour
{
    private void Start()
    {
        Boss midboss = new Boss();

        midboss.Attack();
        midboss.Deffence(8);
        midboss.Magic(5);
    
    }
    private void Update()
    {

    }
}