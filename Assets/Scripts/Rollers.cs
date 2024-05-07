using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rollers : MonoBehaviour {
    private Rigidbody rb;

    public float torque = 0.3f;
    public float rotationDirection = 1;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update() {      
              
    }

    void FixedUpdate() {
        rb.AddTorque(transform.up * torque * 100000 * rotationDirection);
    }

    
}
