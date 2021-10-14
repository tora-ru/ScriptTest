using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        //要素数の配列を初期化する
        int[] array = new int[5];
        //配列の各要素に値を代入する
        array[0] = 67;
        array[1] = 10101;
        array[2] = 88;
        array[3] = 99;
        array[4] = 77;
        // 配列の要素をすべて表示する
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






