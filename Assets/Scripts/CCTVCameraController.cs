 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CCTVCameraController : MonoBehaviour
{
    public float turnSpeed = 5f;

    public float turnAngle = 90;

    bool turningRight = !true;

    Transform cameraLens;
    // Start is called before the first frame update
    void Start()
    {
        Transform cameraPosition = transform.Find("Camera");
        cameraLens = cameraPosition.Find("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        //  if (turningRight)
        //        TurnLeft();
        //  else
        //        TurnRight();
        //  CheckAngleLeft();
        //  CheckAngleRight();
        transform.rotation = Quaternion.Euler(new Vector3(0, Mathf.PingPong(Time.time, 9) * 10 - 45, 0));
        //CheckIfPlayerVisible();
    }
    /* void CheckIfPlayerVisible()
    {
        Debug.DrawRay(cameraLens.position, cameraLens.TransformDirection(Vector3.down) * 100, Color.yellow);


    }
    */
    /*
    void TurnRight()
    {
        transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed);
    }
    void TurnLeft()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
    }
    void CheckAngleLeft()
    {
        if(transform.rotation.eulerAngles.y > turnAngle)
        {
            turningRight = !turningRight;
        }
        
    }
    void CheckAngleRight()
    {
        if (transform.rotation.eulerAngles.y < turnAngleminus / 2)
        {
            turningRight = !turningRight;
        }
    }
    */
}
