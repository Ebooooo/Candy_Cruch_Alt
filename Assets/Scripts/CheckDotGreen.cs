using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckDotGreen : MonoBehaviour
{
    public bool markedToDestroy;
    public bool readyToDestroy;

    public void Start()
    {
        readyToDestroy = false;
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
