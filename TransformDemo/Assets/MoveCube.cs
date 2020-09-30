using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // timer += 1;
        timer += Time.deltaTime;
        Debug.Log("Time passed: " + timer);

        //Space.World is absolute coordinate system. Space.self is defauly which is local
        //transform.Translate(Vector3.forward * Time.deltaTime,Space.World); //Time.deltaTime updates based on how fast the computer is. If 60 times per second, va;ue is 1/60
        //transform.Translate(0.8f * Vector3.forward);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
        }

        //Input.GetKey keeps returning true when the button is pressed down. Example: Moving a person vs Input.GetKeyDown. GetKeyDown returns true only once. Example: flashlight.

        Debug.Log("Z- " + transform.position.z);
        
    }

}