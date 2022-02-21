using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOnHit_Script : MonoBehaviour
{


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.name.Equals(gameObject.name))
        {
            return;
        }
        Debug.Log(gameObject.name + " Bullet Hit:" + collision.gameObject.name);
        GameObject handler = GameObject.FindGameObjectWithTag("GameHandler");
        handler.GetComponent<PingHandler_Script>().CreatePing(new Vector2Int(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y)));
        Destroy(gameObject);
    }
}
