using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPhysics : MonoBehaviour{
    //adjustables
    public float speed;
    [SerializeField] private float lifetime;
    
    //establish objects

    //establish contants
    public Vector3 velocity;
    public float rotation; 

    public virtual void Start(){
        transform.rotation = Quaternion.Euler(0, rotation, 0);
        StartCoroutine(DestoryBulletAfterTime());
    }

    void FixedUpdate(){
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public virtual void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") return;
        if (other.gameObject.tag == "EnemyBullets") return;
        {
            //Destroy(gameObject);
            //Destroy(other.gameObject);
        }
    }
    public IEnumerator DestoryBulletAfterTime(){
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}