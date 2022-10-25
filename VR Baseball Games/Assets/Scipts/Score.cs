using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private string objname;
    public GameObject scoreText;
    int score = 0;

    void OnCollisionEnter(Collision collision)
    {
        objname = collision.gameObject.name;
        if (objname == "Ball(Clone)")
        {
            score++;
            scoreText.GetComponent<TextMesh>().text = "Score : " + score.ToString();
        }
    }

}
