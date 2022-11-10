using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DestroyBlock : MonoBehaviour
{
    public TextMeshProUGUI txt;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("highscore")) {
            PlayerPrefs.SetInt("highscore", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score: "+ score;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("block"))
        {
            Destroy(col.gameObject);
            score++;
            PlayerPrefs.SetInt("score", score);
        }
    }
}
