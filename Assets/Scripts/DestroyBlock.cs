using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DestroyBlock : MonoBehaviour
{
    public AudioSource down;
    public GameObject[] bricks;
    public TextMeshProUGUI txt, txt2;
    public GameObject level1, level2;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("highscore")) {
            PlayerPrefs.SetInt("highscore", 0);
        }
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score: "+ PlayerPrefs.GetInt("score");
        txt2.text = "High: "+ PlayerPrefs.GetInt("highscore");

        bricks = GameObject.FindGameObjectsWithTag("brick");
        if (bricks.Length < 0)
        {   
            bricks = GameObject.FindGameObjectsWithTag("brick1");
            if (bricks.Length < 0)
            {
                level1.SetActive(false);
                level2.SetActive(true);
            }
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("brick"))
        {
            down.Play(0);
            Destroy(col.gameObject);
            score = PlayerPrefs.GetInt("score") + 1;
            PlayerPrefs.SetInt("score", score);
            if (PlayerPrefs.GetInt("highscore") < PlayerPrefs.GetInt("score"))
            {
                PlayerPrefs.SetInt("highscore", PlayerPrefs.GetInt("score"));
            }
        }
        else if (col.gameObject.CompareTag("brick2"))
        {
            col.gameObject.tag = "brick";
        }
    }
}
