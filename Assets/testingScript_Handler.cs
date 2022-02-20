using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingScript_Handler : MonoBehaviour
{
    [SerializeField] PingHandler_Script pingScr;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pingScr.CreatePing(new Vector2Int(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x), Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y)));
        }
    }
}
