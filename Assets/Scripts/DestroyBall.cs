using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    public GameObject lives3, lives2, lives1, lives0, ball3, ball2, ball1;
    int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        lives3.SetActive(true);
        lives2.SetActive(false);
        lives1.SetActive(false);
        lives0.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ball"))
        {
            Destroy(col.gameObject);
            lives--;
            if(lives == 3)
            {
                ball3.SetActive(true);
                ball2.SetActive(false);
                ball1.SetActive(false);
            }
            if(lives == 2)
            {
                ball2.SetActive(true);
                lives3.SetActive(false);
                lives2.SetActive(true);
                lives1.SetActive(false);
                lives0.SetActive(false);
            }
            if(lives == 1)
            {
                ball1.SetActive(true);
                lives3.SetActive(false);
                lives2.SetActive(false);
                lives1.SetActive(true);
                lives0.SetActive(false);
            }
            if(lives == 0)
            {
                lives3.SetActive(false);
                lives2.SetActive(false);
                lives1.SetActive(false);
                lives0.SetActive(true);
            }
        }
    }
}
