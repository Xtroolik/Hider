using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    Transform player;
    Vector3 cameraOffset;
    Vector3 cameraSpeed;
    float smoothTime = 0.3f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        cameraOffset = transform.position - player.position;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // transform.position = player.position + cameraOffset
        Vector3 targetPosition = player.position + cameraOffset;
        // transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref cameraSpeed, smoothTime);
    }
}
