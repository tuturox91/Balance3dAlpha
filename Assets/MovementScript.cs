using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float Speed;
    public float movementhorizontal;
    public float movementVertical;

    public Vector3 movement;
    public Vector3 Inertia;

    public bool FullStop;


    public int TypeOfPlayer = 1;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

        var maxSpeed = 35; //normal maxSpeed is 7

        rb.maxAngularVelocity = (maxSpeed);

    }

    // Update is called once per frame
    void Update()
    {
        if (FullStop == false)
        {
            movementhorizontal = Mathf.Clamp(Input.GetAxis("Horizontal") * 3f, -1, 1);
            movementVertical = Mathf.Clamp(Input.GetAxis("Vertical") * 3f, -1, 1);

            /*if (Input.GetKeyDown(KeyCode.A))
             {
                 movementhorizontal = -1;
             }
                if (Input.GetKeyDown(KeyCode.D))
             {
                 movementhorizontal = 1;
             } */

            movement = new Vector3(movementhorizontal, 0.0f, movementVertical);

            Inertia = rb.inertiaTensor;


            rb.AddForce(movement * Speed);
        }
    }
}
