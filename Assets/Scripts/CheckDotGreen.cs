using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDotGreen : MonoBehaviour
{
    public bool markedToDestroy;
    public bool readyToDestroy;

    public void Start()
    {
        markedToDestroy = false;
    }

    public void OnTriggerStay2D(Collider2D dotGreen)
    {
        if(dotGreen.tag == "ClearCheckerGreen")
        {
            markedToDestroy = true;
        }
    }
    
    public void Update()
    {
        if(readyToDestroy && markedToDestroy)
        Destroy(gameObject);
    }

    public void pointerDown()
    {
       Debug.Log("e dzialasz?");
       readyToDestroy = true;
    }
    public void pointerUp()
    {
       Debug.Log("e dzialaddddsz?");
       readyToDestroy = false;
    }
}
