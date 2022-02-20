using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 2000f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = -transform.right * speed;


    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "IgnoreFireball")
        {
            //Destroy(gameObject);
        }

    }
}
