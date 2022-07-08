using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    public GameObject spawner;
    public bool drag;

    void OnMouseUp()
    {
        drag = false;
    }
    void OnMouseDrag()
    {
        drag = true;
        transform.position = GetMousePos();
    }

    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
    private void OnTriggerStay2D(Collider2D other) 
    {
       if(other.tag == "Board")
       {
        spawner.transform.position = new Vector2(other.transform.position.x, other.transform.position.y);
       } 
    }
}
