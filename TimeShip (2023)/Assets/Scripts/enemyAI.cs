using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class enemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isRunning;
    public int number;
    private gameManager gameManager;
    public int test1 = 1;

    //Starto!
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

/*
//IEnumerator
//Moves ship in a set distace in the x and y axis
    public IEnumerator MoveShip(int xCor, int zCor){
        isRunning = true;
        Vector3 v3 = transform.position;
        v3.x += 10 * xCor;
        v3.z += 10 * zCor;
        transform.position = v3;
        isRunning = false;
        number++;
        StopCoroutine(MoveShip(0,0));
    }
*/

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
