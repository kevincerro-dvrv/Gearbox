using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    public GameObject ballPrefab;
    public Transform ballSource;


    public Rollers leftRoller;
    public Rollers rightRoller;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(ballPrefab, ballSource.position, Quaternion.identity);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            leftRoller.torque -= 10;
            rightRoller.torque -= 10;
        } 

        if(Input.GetKeyDown(KeyCode.DownArrow)) {
            leftRoller.torque -= 10;
            rightRoller.torque -= 10;
        } 

        
    }
}
