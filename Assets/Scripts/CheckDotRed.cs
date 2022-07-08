using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDotRed : MonoBehaviour
{
    public bool markedToDestroy;
    public bool clearClicked;

    public void Start()
    {
        markedToDestroy = false;
        clearClicked =false;
    }

    public void OnTriggerStay2D(Collider2D dotRed)
    {
        if(dotRed.tag == "ClearCheckerRed")
        {
            markedToDestroy = true;
        }
    }
    
    public void pointerDown()
    {
        if(markedToDestroy)
        {
            Destroy(gameObject);
        }
    }
}
