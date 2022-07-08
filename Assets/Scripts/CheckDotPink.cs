using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDotPink : MonoBehaviour
{
    public bool markedToDestroy;

    public void Start()
    {
        markedToDestroy = false;
    }

    public void OnTriggerStay2D(Collider2D dotRed)
    {
        if(dotRed.tag == "dotPink")
        {
            markedToDestroy = true;
        }
    }
}
