using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToCreate : MonoBehaviour
{
    public SquareCheck checker;
    public bool isChecking;
    // Start is called before the first frame update
    void Start()
    {
        checker = GameObject.Find("Checker").GetComponent<SquareCheck>();
    }

    public void pointerDown()
    {
        isChecking = true;
    }
    public void pointerUP()
    {
        isChecking =false;
    }
    public void Update()
    {
        if(isChecking)
        {
            checker.degree = checker.degree + 1;
        }
    }
}
