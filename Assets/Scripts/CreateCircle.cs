using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCircle : MonoBehaviour
{
    public Transform spawnLocation;
    public GameObject[] colors;
    
    void Update()
    {
       if(Input.GetKeyDown("up"))
       {
        Instantiate(colors[UnityEngine.Random.Range(0,3)], spawnLocation.position, spawnLocation.rotation);
       } 
    }
}
