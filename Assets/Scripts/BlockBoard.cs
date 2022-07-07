using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBoard : MonoBehaviour
{
    public SpriteRenderer sr;
    public bool isBlocked;
    public bool blocked;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        isBlocked = false;
        blocked = Random.Range(0f, 100.0f) <=25f;
        if(blocked)
        {
            isBlocked = true;
            sr.color = new Color(0f, 0f, 0f);
        }
    }
}
