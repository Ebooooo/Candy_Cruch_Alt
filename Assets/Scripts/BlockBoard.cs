using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBoard : MonoBehaviour
{
    public SpriteRenderer sr;
    public GameObject[] colors;
    public SquareCheck isCheck;
    public bool isBlocked;
    public bool blocked;
    public bool empty;
    public bool spawner;

    void Start()
    {
        isCheck = GameObject.Find("Squaremake").GetComponent<SquareCheck>();
        spawner = false;
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
        if(other.tag == "spawner")
        {
            spawner = true;
        }
        if(other.tag == "check" && !isBlocked && empty && !spawner && isCheck.isChecking)
        {
            Instantiate(colors[UnityEngine.Random.Range(0,3)], this.transform.position, this.transform.rotation);
            empty = false;
        }
    }
    void OnTriggerExit2D(Collider2D dot)
    {
        if(dot.tag == "spawner")
        {
            spawner = false;
        }
        if(dot.tag == "dotGreen" || dot.tag == "dotPink" || dot.tag == "dotRed" && !isBlocked)
        {
            empty = true;
        }
    }
}
