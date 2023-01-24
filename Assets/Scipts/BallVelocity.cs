using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVelocity : MonoBehaviour
{ 
    private void OnCollisionEnter(Collision other)
    {
        int changePower = 500; //ïœâªóÕ
        Vector3 Direction = new Vector3(0, 1.0f, 2.0f); 
        if (other.gameObject.tag == "Ball")
        {
            Rigidbody ball_rb = other.gameObject.GetComponent<Rigidbody>();
            ball_rb.AddForce(Direction * changePower);//É{Å[ÉãÇ…óÕÇâ¡Ç¶ÇÈ
        }
    }
}
