using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        //�v�f���̔z�������������
        int[] array = new int[5];
        //�z��̊e�v�f�ɒl��������
        array[0] = 67;
        array[1] = 10101;
        array[2] = 88;
        array[3] = 99;
        array[4] = 77;
        // �z��̗v�f�����ׂĕ\������
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}






