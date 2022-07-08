using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDotPink : MonoBehaviour
{
    public bool markedToDestroy;
    public bool readyToDestroy;

    public void Start()
    {
        readyToDestroy = false;
        markedToDestroy = false;
    }

    public void OnTriggerStay2D(Collider2D dotPink)
    {
        if(dotPink.tag == "ClearCheckerPink")
        {
            markedToDestroy = true;
        }
    }
    
    public void Update()
    {
        clickDown();
        if(readyToDestroy && markedToDestroy)
        Destroy(gameObject);
    }

    public void clickDown()
    {
        if(Input.GetKey(KeyCode.E))
        {
       readyToDestroy = true;
        }
    }
}
