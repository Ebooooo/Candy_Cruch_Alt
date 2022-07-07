using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareCheck : SquareTangent
{
    public GameObject squarePrefab, checkPrefab;
    public GameObject movementPrefab;
    private GameObject innerSquareMove, outterSquareMove, tangentSquareMove;
    public Vector4 innerSquare, outterSquare;
    public float tangentSquareRadius;
    public float degree;

    void Start()
    {
        innerSquareMove = (GameObject)Instantiate(squarePrefab);
        outterSquareMove = (GameObject)Instantiate(squarePrefab);
        tangentSquareMove = (GameObject)Instantiate(checkPrefab);
        movementPrefab = (GameObject)Instantiate(movementPrefab);
        outterSquare.w = 0.5f;
        tangentSquareRadius = 0.125f;
    }


    void Update()
    {
        GrowUp();
        Check();
        innerSquareMove.transform.position = new Vector2(innerSquare.x, innerSquare.y);
        innerSquareMove.transform.localScale = new Vector2(innerSquare.w, innerSquare.w) * 2;
        outterSquareMove.transform.position = new Vector2(movementPrefab.transform.position.x, movementPrefab.transform.position.y);
        outterSquareMove.transform.localScale = new Vector2(outterSquare.w, outterSquare.w) * 2;
        tangentSquareMove.transform.position = GetRotatedTangent(degree, outterSquare.w) + outterSquareMove.transform.position;
        tangentSquareMove.transform.localScale = new Vector2(tangentSquareRadius, tangentSquareRadius) * 2;
    }

    public void GrowUp()
    {
        if(degree == 360)
        {
            degree = 0;
            outterSquare.w = outterSquare.w + 1;
            tangentSquareRadius = tangentSquareRadius + 0.25f;
        }
    }
    public void Check()
    {
        if(Input.GetKey(KeyCode.T))
        {
            degree++;
        }
    }
}
