using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCollider : MonoBehaviour
{
    int changePower = 150; //変化力
    Vector3 sliderDirection = new Vector3(1.0f, 0, 0); //スライダー
    Vector3 forkDirection = new Vector3(0, -1.0f, 0); //フォーク
    Vector3 shutoDirection = new Vector3(-1.0f, 0, 0); //シュート
    Vector3 SuperSDirection = new Vector3(0, 1.0f, 0); //本気のまっすぐ

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Rigidbody ball_rb = other.gameObject.GetComponent<Rigidbody>();
            int num = UnityEngine.Random.Range(0, 5);

            switch (num)
            {
                case 0:
                    ball_rb.AddForce(sliderDirection * changePower);//ボールに力を加える
                    break;
                case 1:
                    ball_rb.AddForce(forkDirection * changePower);
                    break;
                case 2:
                    ball_rb.AddForce(shutoDirection * changePower);
                    break;
                case 3:
                    ball_rb.AddForce(SuperSDirection * changePower);
                    break;
                case 4:
                    break; //ストレート
            }
        }
    }
}

