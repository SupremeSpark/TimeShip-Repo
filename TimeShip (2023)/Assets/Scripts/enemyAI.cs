using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class enemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isRunning;
    public int moveDelay;
    public int number;
    private gameManager gameManager;
    public int test1 = 1;
    public TextMeshProUGUI turnText;
    //Starto!
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

//IEnumerator
//Moves ship in a set distace in the x and y axis
    public IEnumerator MoveShip(int xCor, int zCor){
        isRunning = true;
        yield return new WaitForSeconds(moveDelay);
        Vector3 v3 = transform.position;
        v3.x += 10 * xCor;
        v3.z += 10 * zCor;
        transform.position = v3;
        isRunning = false;
        number++;
        StopCoroutine(MoveShip(0,0));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameManager.StartCoroutine(gameManager.whoTurn(1));
        if (!isRunning && gameManager.playerTurn == -1) {
            turnText.text = "Enemy" + " Turn";
            StartCoroutine(MoveShip(1,0));
            gameManager.playerTurn = test1;
        }
    }
}
