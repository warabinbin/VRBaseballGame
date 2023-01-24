using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    //音源格納 変数
    public AudioClip clip;
    private string objname;

    void OnCollisionEnter(Collision collision)
    {
        objname = collision.gameObject.name;
        if (objname == "Ball(Clone)")
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
