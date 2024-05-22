using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3? cursorWorldPosition = CursorWorldPosition();
        if(cursorWorldPosition != null) 
        {
            // Debug.Log("Cursor Position: " + cursorWorldPosition.ToString());
            transform.LookAt((Vector3)cursorWorldPosition + Vector3.up);
        }
    }
    private void OnMouseDown()
    {
        Debug.Log("Clicked: " + gameObject.name);
    }
    Vector3? CursorWorldPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            return hit.point;
        } else
        {
            return null;

        }
    }
}
