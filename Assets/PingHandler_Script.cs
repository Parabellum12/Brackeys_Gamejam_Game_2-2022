using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingHandler_Script : MonoBehaviour
{

    [SerializeField] GameObject ping_PreFab;

    [SerializeField] float pingTimer = 5f;
    [SerializeField] float scale = 5f;
    [SerializeField] float increaseAmount = 5f;

    public void CreatePing(Vector2Int pos)
    {
        GameObject ping = Instantiate(ping_PreFab, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
        ping.GetComponent<Ping_Script>().activate(pingTimer, scale, increaseAmount);
        //ping.transform.parent = gameObject.transform;
    }
}
