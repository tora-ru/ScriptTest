using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour

{
    // Use this for initialization
    void Start()
    {
        //�z�������������
        int[] array = {30, 20, 50, 10, 80, 15, 60, 100};
        // �z��̗v�f�����ׂĕ\������
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log (array [i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
