using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    //Use this for initialization
    void Start ()
    {
        //�z�������������
        int[] array = {30, 20, 50, 10, 80, 15, 60, 100};

        //�z��̕������������J��Ԃ�
        for (int i = array.Length-1; i >= 0; i--)
        {
                //�z��̗v�f��\������
                Debug.Log (array [i]);
        }
    }

    //Update is called once per frame
    void Update ()
    {

    }
}