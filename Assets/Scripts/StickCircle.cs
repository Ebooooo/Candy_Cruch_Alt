using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickCircle : MonoBehaviour
{
    public GameObject Circle;
    public bool used;
    public GameObject[] Board;

    void Start()
    {
        used = false;
    }
    public void FindClosestEmpty()
    {
        float distanceToCloasestEmpty = Mathf.Infinity;
        BlockBoard closestBoard = null;
        BlockBoard[] allBoards = GameObject.FindObjectsOfType<BlockBoard>();

        foreach (BlockBoard currentBoard in allBoards)
        {
            float distanceToBoard = (currentBoard.transform.position - this.transform.position).sqrMagnitude;
            if(distanceToBoard < distanceToCloasestEmpty && !used)
            {
                distanceToCloasestEmpty = distanceToBoard;
                closestBoard = currentBoard;
                used = true;
                this.transform.position = currentBoard.transform.position;
            }
        }
        Debug.Log("znalazlem najblizszy");
    }

    void Update()
    {
        FindClosestEmpty();
    }
}
