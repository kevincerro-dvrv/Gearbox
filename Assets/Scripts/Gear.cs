using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public float torque = 0.5f;

    private Rigidbody rb;
    private bool throtle;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        throtle = Input.GetKey(KeyCode.Space);
    }

    void FixedUpdate()
    {
        if (throtle) {
            rb.AddTorque(transform.up * torque );
        }
    }
}
