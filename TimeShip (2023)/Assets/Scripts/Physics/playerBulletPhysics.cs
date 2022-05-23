using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBulletPhysics : MonoBehaviour
{
    //adjustables
    [SerializeField] private float speed;
    [SerializeField] private float lifetime;
    //establish objects

    void Start(){
        StartCoroutine(DestoryBulletAfterTime());
    }
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") return;
        if (other.gameObject.tag == "PlayerBullets") return;
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

    IEnumerator DestoryBulletAfterTime(){
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
