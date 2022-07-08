using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrag : MonoBehaviour
{
    private Vector3 Origin;
    private Vector3 Difference;
    public DragDrop spawnerDrag;
    private bool drag = false;

    public void Start()
    {
        spawnerDrag = GameObject.Find("Spawner").GetComponent<DragDrop>();
    }
    void Update()
    {
        if(Input.GetMouseButton(0) && !spawnerDrag.drag)
        {
            Difference = (Camera.main.ScreenToWorldPoint(Input.mousePosition)) - Camera.main.transform.position;
            if(drag == false)
            {
                drag = true;
                Origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
        else
        {
            drag = false;
        }

        if(drag)
        {
            Camera.main.transform.position = Origin - Difference;
        }
    }
}
