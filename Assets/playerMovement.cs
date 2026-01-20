using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // new

public class playerMovement : MonoBehaviour
{
    Rigidbody2D Rb; // inisialisasi
    public float jumpForce; // jump loncat
    float score;

    public Text scoreTxt; // new

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>(); // perkenalan inisialisasi
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "" + score; // new

        if (Input.GetMouseButtonDown(0)) // klik mouse kiri for pc / tap untuk hp
        {
            Rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            score++;
        }

        if (collision.gameObject.tag == "pipa")
        {
            Destroy(gameObject);
        }
    }
}
