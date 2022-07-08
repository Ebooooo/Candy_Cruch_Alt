using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDotGreen : MonoBehaviour
{
    public bool markedToDestroy;
    public bool clearClicked;

    public void Start()
    {
        markedToDestroy = false;
    }

    public void OnTriggerStay2D(Collider2D dotRed)
    {
        if(dotRed.tag == "dotGreen")
        {
            markedToDestroy = true;
        }
    }
    
        public void pointerDown()
    {
        clearClicked = true;
    }
    public void pointerUP()
    {
        clearClicked =false;
    }
    public void Update()
    {
        if(markedToDestroy && clearClicked)
        {
        Destroy(gameObject);
        Debug.Log("halogreen?");
        }
    }
}
