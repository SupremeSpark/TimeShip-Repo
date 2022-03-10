using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    //Establishing Objects 
    private PlayerActions controls;
    private Rigidbody playerRB;
    //movement
    [SerializeField] private float speed;
    [SerializeField] private float movementX;
    [SerializeField] private float movementZ;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float offset;
    //Enable/Disable Input
    private void Awake(){controls = new PlayerActions();}
    private void OnEnable(){controls.Enable();}
    private void OnDisable(){controls.Disable();}

    void Start()
    {
     //Establish values & objects
        //objects and componets
        playerRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){
        //input
        movementX = controls.ShipControl.MovementX.ReadValue<float>();
        movementZ = controls.ShipControl.MovementZ.ReadValue<float>();
        Vector3 movement = new Vector3(movementX, 0 ,movementZ);

        //skewing
        var matrix = Matrix4x4.Rotate(Quaternion.Euler(0,45,0));
        var skewedMovement = matrix.MultiplyPoint3x4(movement);
        transform.position += skewedMovement * speed * Time.deltaTime;

        //looking/turning
        /*
        if (movement != Vector3.zero){
            var relative = (transform.position - skewedMovement) - transform.position;
            var rot = Quaternion.LookRotation(relative, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, turnSpeed * Time.deltaTime);
        }
        */
    }

    void Move(){

    }
}
