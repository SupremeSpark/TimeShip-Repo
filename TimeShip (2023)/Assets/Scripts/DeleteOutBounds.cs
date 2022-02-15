using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOutBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody objectRB;
    public float zDestory = 60;
    public float xDestory = 60;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > zDestory){
            Destroy(gameObject);}
        if(transform.position.z < -zDestory){
            Destroy(gameObject);}
        if(transform.position.x > xDestory){
            Destroy(gameObject);}
        if(transform.position.x < -xDestory){
            Destroy(gameObject);}
    }
}
