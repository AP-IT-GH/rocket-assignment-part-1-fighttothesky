using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRocket : MonoBehaviour
{
    //Fleur Van Buijten
    private const int Speed = 4;
    private const int RotationSpeed = 1;


    private Rigidbody body;
    

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {  
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = transform.up * Speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, RotationSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -RotationSpeed);
        }
    }
}
