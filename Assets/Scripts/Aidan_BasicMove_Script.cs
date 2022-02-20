using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aidan_BasicMove_Script : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y);
    }
}
