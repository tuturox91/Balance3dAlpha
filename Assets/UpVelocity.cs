using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private bool startm = false;
    private GameObject plyer;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            startm = true;
            plyer = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            startm = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(startm == true)
        {
            Vector3 movement = new Vector3(0f, 1.0f, 0f);
            plyer.GetComponent<Rigidbody>().AddForce(movement);
        }
    }
}
