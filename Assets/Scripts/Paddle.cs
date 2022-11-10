using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public GameObject ballprefab;
    Gyroscope gyro;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
        rb = GetComponent<Rigidbody2D>();
        gyro = Input.gyro;
        gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        Vector3 movement = new Vector3 (-Input.gyro.attitude.y, 0.0f, 0.0f);
        rb.velocity = movement * speed * 40f;
    }
}
