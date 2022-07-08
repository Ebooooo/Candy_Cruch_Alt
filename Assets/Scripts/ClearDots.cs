using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearDots : MonoBehaviour
{
    public GameObject dotRed;
    public GameObject dotGreen;
    public GameObject dotPink;
    public bool markedToDestroy;

    public void Start()
    {
        markedToDestroy = false;
    }

    public void OnTriggerStay2D(Collider2D dotRed)
    {
        if(dotRed.tag == "dotRed" && gameObject.tag == "dotRed")
        {
            markedToDestroy = true;
        }
    }

    public void OnClickClearRed()
    {
        if(markedToDestroy)
        {
        Destroy(gameObject);
        Debug.Log("halo?");
        }
    }
    public void Update()
    {
        OnClickClearRed();
    }
}
