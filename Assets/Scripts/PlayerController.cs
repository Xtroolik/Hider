using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 5f;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

        float x = Input.GetAxisRaw("Horizontal");
        // Debug.Log(x);

        Vector3 movement = Vector3.right * x;

        float y = Input.GetAxisRaw("Vertical");

        movement += Vector3.forward * y;

        movement = movement.normalized;
        movement *= Time.deltaTime;
        movement *= moveSpeed;

        //transform.position += movement;

        transform.Translate(movement);

        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void Jump()
    {
        if (transform.position.y <= Mathf.Epsilon)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("BBBB");
    }
}
