using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    public GameObject lives3, lives2, lives1, lives0;
    public GameObject ballprefab;
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
            if(lives != 0)
            {
                Instantiate(ballprefab, new Vector3(-0.03f,-3.40f,0), Quaternion.identity);
            }
            if(lives == 2)
            {
                lives3.SetActive(false);
                lives2.SetActive(true);
                lives1.SetActive(false);
                lives0.SetActive(false);
            }
            if(lives == 1)
            {
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
