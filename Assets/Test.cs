using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    //Use this for initialization
    void Start ()
    {
        //�z�������������
        int[] array = {67, 10101, 66, 77, 88};

        //�z��̕������������J��Ԃ�
        for (int i = 0; i < array.Length; i++)
        {
                //�z��̗v�f��\������
                Debug.Log(array[i]);
        }

        for (int i = array.Length-1; i >= 0; i--)
        {
                Debug.Log(array[i]);
        }
    }

    //Update is called once per frame
    void Update ()
    {

    }
}