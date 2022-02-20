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
        ShipAim();
    }
    private void ShipAim(){
        Vector2 mouseScreenPosition = controls.ShipControl.AimMousePos.ReadValue<Vector2>();
        Vector3 mouseWorldPosition = mainCam.ScreenToWorldPoint(mouseScreenPosition);
        Vector3 targetDirection = mouseWorldPosition - transform.position;
        float angle = Mathf.Atan2(targetDirection.x, targetDirection.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, angle, 0f));
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
