using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour

{
    // Use this for initialization
    void Start()
    {
        //配列を初期化する
        int[] array = {30, 20, 50, 10, 80, 15, 60, 100};

        // 配列の要素をすべて表示する
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
