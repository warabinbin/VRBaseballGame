using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCollider : MonoBehaviour
{
    int changePower = 150; //�ω���
    Vector3 sliderDirection = new Vector3(1.0f, 0, 0); //�X���C�_�[
    Vector3 forkDirection = new Vector3(0, -1.0f, 0); //�t�H�[�N
    Vector3 shutoDirection = new Vector3(-1.0f, 0, 0); //�V���[�g
    Vector3 SuperSDirection = new Vector3(0, 1.0f, 0); //�{�C�̂܂�����

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Rigidbody ball_rb = other.gameObject.GetComponent<Rigidbody>();
            int num = UnityEngine.Random.Range(0, 5);

            switch (num)
            {
                case 0:
                    ball_rb.AddForce(sliderDirection * changePower);//�{�[���ɗ͂�������
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
                    break; //�X�g���[�g
            }
        }
    }
}

