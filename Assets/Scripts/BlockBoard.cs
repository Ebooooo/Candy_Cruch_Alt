using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBoard : MonoBehaviour
{
    public SpriteRenderer sr;
    public GameObject[] colors;
    public bool isBlocked;
    public bool blocked;
    public bool empty;

    void Start()
    {
        empty = true;
        sr = GetComponent<SpriteRenderer>();
        isBlocked = false;
        blocked = Random.Range(0f, 100.0f) <=25f;
        if(blocked)
        {
            isBlocked = true;
            sr.color = new Color(0f, 0f, 0f);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "check" && !isBlocked && empty)
        {
            Instantiate(colors[UnityEngine.Random.Range(0,3)], this.transform.position, this.transform.rotation);
            empty = false;
        }
    }
}
