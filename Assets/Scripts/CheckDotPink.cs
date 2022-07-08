using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDotPink : MonoBehaviour
{
    public bool markedToDestroy;
    public bool clearClicked;

    public void Start()
    {
        markedToDestroy = false;
        clearClicked =false;
    }

    public void OnTriggerStay2D(Collider2D dotPink)
    {
        if(dotPink.tag == "ClearCheckerPink")
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
