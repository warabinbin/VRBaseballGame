using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class CreateBall : MonoBehaviour
{
    public GameObject F_Object;   //GameObject取得  
    private float tmpTime = 0.0f;
    private float R_Time = 0.0f;
    private int Num = 0;
    [SerializeField] int Num_oj;

    void Update()
    {
        //座標生成
        float x = 0f;
        float y = 0.7f;
        float z = 5f;

        tmpTime += Time.deltaTime;

        // (Num_oj)個の物体を生成
        if (Num < Num_oj)
        {
            //2sから5sおきに生成
            if (tmpTime >= R_Time + 2.0f)
            {
                Debug.Log("生成時間：" + Time.time);
                Instantiate(F_Object, new Vector3(x, y, z), Quaternion.identity);
                Num++;
                tmpTime = 0;
                R_Time = UnityEngine.Random.Range(0.0f, 3.0f);
            }
        }
    }
}
