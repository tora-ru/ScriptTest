using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        //�z�������������
        int[] array = { 67, 10101, 77, 88, 99 };
        // �z��̗v�f�����ׂĕ\������
        for (int i = array.Length-1; i >= 0; i--)
        {
            Debug.Log (array [i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
