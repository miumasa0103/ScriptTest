using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
       
        int[] array ={ 30, 60, 90, 120, 150 }; //要素が５個の配列arrayの宣言,初期化

        for (int i = 0; i<array.Length; i++)    //配列の各要素の値を順番に表示させる
        {
            Debug.Log(array[i]);
        }

        for (int j = array.Length - 1; j >= 0; j--)　　//配列の各要素の値を逆順に表示させる
        {
            Debug.Log(array[j]);
        }

    }
    void Update()

    {

    }
}