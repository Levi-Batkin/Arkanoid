using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public TextMeshProUGUI countdowntxt;
    IEnumerator Countdown()
    {
        countdowntxt.text = "3";
        yield return new WaitForSeconds(1);
        countdowntxt.text = "2";
        yield return new WaitForSeconds(1);
        countdowntxt.text = "1";
        yield return new WaitForSeconds(1);
        countdowntxt.text = "Go!";
        rb.constraints = RigidbodyConstraints2D.None;
        rb.AddForce(new Vector2(9.8f * 25f, 9.8f * 25f));
        yield return new WaitForSeconds(0.7f);
        countdowntxt.text = "";
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
}
