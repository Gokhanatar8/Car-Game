using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //private variables
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //aracý ileri hareket ettireceðiz
        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward);
        //deltatime, gerçek zamanlý kare hýzý almayý saðlar
        transform.Translate(UnityEngine.Vector3.forward * Time.deltaTime * speed * forwardInput);
        //we rotate the vehicle
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
