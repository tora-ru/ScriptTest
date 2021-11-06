using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    //Use this for initialization
    void Start ()
    {
        //配列を初期化する
        int[] array = {30, 20, 50, 10, 80, 15, 60, 100};

        //配列の分だけ処理を繰り返す
        for (int i = array.Length-1; i >= 0; i--)
        {
                //配列の要素を表示する
                Debug.Log (array [i]);
        }
    }

    //Update is called once per frame
    void Update ()
    {

    }
}