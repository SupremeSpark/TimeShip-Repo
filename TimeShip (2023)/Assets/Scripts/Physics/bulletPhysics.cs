using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPhysics : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifetime;







    IEnumerator DestoryBulletAfterTime(){
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") return; {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
