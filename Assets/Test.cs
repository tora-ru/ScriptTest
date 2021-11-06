using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    //Use this for initialization
    void Start ()
    {
        //配列を初期化する
        int[] array = {67, 10101, 66, 77, 88};

        //配列の分だけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 50)
            {
                //配列の要素を表示する
                Debug.Log(array[i]);
            }
        }
    }

    //Update is called once per frame
    void Update ()
    {

    }
}