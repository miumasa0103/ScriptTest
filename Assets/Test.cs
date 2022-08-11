using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 50; //体力
    private int power = 10; //攻撃力
    private int mp = 53; //魔力の量
    //攻撃の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");

    }

    //防御の関数
    public void Deffence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");

        this.hp -= damage;


    }

    //魔法の関数
    public void Magic(int cost)
    {
        while(this.mp>=5)                 //MPが5になるまで、繰り返しMP消費
        {
            this.mp -= cost;
        
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);

         }
          
           
        Debug.Log("MPが足りないため、魔法が使えない。");

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