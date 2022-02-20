using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ping_Script : MonoBehaviour
{
    [SerializeField] SpriteMask mask;
    private bool active = false;
    private float timer;
    private float finalScale;
    private float increaseAmount;
    float maxTimer;
    bool grow = true;
    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            if (gameObject.transform.localScale.x < finalScale && grow)
            {
                //Debug.Log("whyyy");
                transform.localScale = new Vector2(transform.localScale.x + (increaseAmount * Time.deltaTime),
                                                   transform.localScale.y + (increaseAmount * Time.deltaTime));
            }
            else
            {
                grow = false;
                if (timer > 0)
                {
                    timer -= 1 * Time.deltaTime;
                    float newx = ((finalScale / maxTimer));
                    float newy = ((finalScale / maxTimer));
                    transform.localScale -= new Vector3(newx, newy) * Time.deltaTime;
                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }
    }

    public void activate(float timer, float scale, float increaseAmount)
    {
        this.increaseAmount = increaseAmount;
        maxTimer = timer;
        finalScale = scale;
        this.timer = timer;
        active = true;
        gameObject.transform.localScale = new Vector3(.1f, .1f, .1f);
    }
}
