using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletPhysics : MonoBehaviour
{
    //adjustables
    public float speed;
    [SerializeField] private float lifetime;
    //establish objects

    //establish contants
    public Vector3 velocity;
    public float rotation; 

    void Start(){
        transform.rotation = Quaternion.Euler(0, rotation, 0);
        StartCoroutine(DestoryBulletAfterTime());
    }
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") return;
        if (other.gameObject.tag == "EnemyBullets") return;

    }

    IEnumerator DestoryBulletAfterTime(){
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
