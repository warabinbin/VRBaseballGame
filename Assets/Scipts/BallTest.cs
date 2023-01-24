using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTest : MonoBehaviour
{
    public Rigidbody m_rb;
    public int power;
    Vector3 direction = new Vector3(0, 0.325f, -1.0f);

    void Start()
    {
        m_rb.AddForce(direction * power);
    }
}