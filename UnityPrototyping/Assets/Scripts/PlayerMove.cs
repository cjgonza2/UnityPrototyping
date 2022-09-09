using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;

    Rigidbody myBody;
    
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float xDirection = Input.GetAxisRaw("Horizontal");

        Vector3 playerDir = new Vector3(xDirection, 0, 0);

        myBody.velocity = new Vector3(xDirection * speed, myBody.velocity.y);
        
    }
}
