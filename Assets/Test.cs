using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
       
        int[] array ={ 30, 60, 90, 120, 150 }; //�v�f���T�̔z��array�̐錾,������

        for (int i = 0; i<array.Length; i++)    //�z��̊e�v�f�̒l�����Ԃɕ\��������
        {
            Debug.Log(array[i]);
        }

        for (int j = array.Length - 1; j >= 0; j--)�@�@//�z��̊e�v�f�̒l���t���ɕ\��������
        {
            Debug.Log(array[j]);
        }

    }
    void Update()

    {

    }
}