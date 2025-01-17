using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour {
    private Rigidbody rb;
    private bool throttle;

    public float torque = 0.3f;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update() {
        throttle = Input.GetKey(KeyCode.Space);                
    }

    void FixedUpdate() {
        if(throttle) {
            rb.AddTorque(transform.up * torque);
        }
    }
}
