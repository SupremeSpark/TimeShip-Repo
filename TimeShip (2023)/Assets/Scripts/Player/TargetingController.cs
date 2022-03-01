using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingController : MonoBehaviour
{
    //Establishing Objects 
    private PlayerActions controls;
    //shooting stuff
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletDirection;
    [SerializeField] Transform BulletPool;
    [SerializeField] float PrimaryCooldown;
    [SerializeField] private bool canShoot = true;
    [SerializeField] private Camera mainCam;
    [SerializeField] private float offset;

    private void Awake(){
        controls = new PlayerActions();
    }
    //Enable/Disable stuff
    private void OnEnable(){controls.Enable();}
    private void OnDisable(){controls.Disable();}


    private void Start(){
        controls.ShipControl.Shoot.performed += _ => TimeShipShoot();
    }


    void Update()
    {
        ShipAimOsoMet();
    }

    private void ShipAimOsoMet(){
        Vector2 mouseScreenPosition = controls.ShipControl.AimMousePos.ReadValue<Vector2>();
        Ray cameraRay = mainCam.ScreenPointToRay(mouseScreenPosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength;

        if(groundPlane.Raycast(cameraRay, out rayLength)){
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }

    private void ShipAimTopDown(){
        //input
        Vector2 mouseScreenPosition = controls.ShipControl.AimMousePos.ReadValue<Vector2>();
        //calculate mouse pos
        Vector3 mouseWorldPosition = mainCam.ScreenToWorldPoint(mouseScreenPosition);
        Vector3 targetDirection = mouseWorldPosition - transform.position;
        //turn mouse pos to angle
        float angle = Mathf.Atan2(-targetDirection.z, targetDirection.x) * Mathf.Rad2Deg - offset;
        //isometric offsetting
        Vector3 finalAngle = new Vector3(0f, angle, 0f);
        var matrix = Matrix4x4.Rotate(Quaternion.Euler(0,45,0));
        var skewedAngle = matrix.MultiplyPoint3x4(finalAngle);
        //moving turret
        transform.rotation = Quaternion.Euler(skewedAngle);
    }
    private void TimeShipShoot(){
        if (!canShoot) return; {
            Vector2 mousePostion = controls.ShipControl.AimMousePos.ReadValue<Vector2>();
            mousePostion = Camera.main.ScreenToWorldPoint(mousePostion);
            GameObject g = Instantiate(bullet, bulletDirection.position, bulletDirection.rotation, BulletPool);
            g.SetActive(true);
            StartCoroutine(CanShoot());
        }
    }
    IEnumerator CanShoot(){
        canShoot = false;
        yield return new WaitForSeconds(PrimaryCooldown);
        canShoot = true;
    }
}
