using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Establishing Objects 
    private PlayerActions controls;
    private Rigidbody playerRB;
    [SerializeField] private gameManager gameManager;
    //movement
    [SerializeField] float movementVelo;
    private void Awake(){
        controls = new PlayerActions();
    }
    //Enable/Disable stuff
    private void OnEnable(){controls.Enable();}
    private void OnDisable(){controls.Disable();}

    void Start()
    {
     //Establish values & objects
        //objects and componets
        playerRB = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
        //inputs
        //controls.ShipControl.Shoot.performed += _ => TimeShipShoot();
    }

    void FixedUpdate(){
        //movement
        //takes vector 2 movement
        Vector3 movement = controls.ShipControl.Movement.ReadValue<Vector2>() * movementVelo;

        //switches y and z values
        

        //takes vecotr 3 movement
        transform.position += movement * Time.deltaTime;
    }
}