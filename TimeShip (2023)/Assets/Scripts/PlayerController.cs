using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public int bayesPieces = 0;
    public GameObject bullet;
    private gameManager gameManager;
    public int loopJump = -1;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v3 = transform.position;
        //PlayerMovement
        
        if (Input.GetKeyDown(KeyCode.W) && gameManager.playerTurn == 1){
            v3.z += 10;
            playerMove();
            transform.position = v3;}

        if (Input.GetKeyDown(KeyCode.D) && gameManager.playerTurn == 1){
            v3.x += 10;
            playerMove();
            transform.position = v3;}

        if (Input.GetKeyDown(KeyCode.S) && gameManager.playerTurn == 1){
            v3.z -= 10;
            playerMove();
            transform.position = v3;}

        if (Input.GetKeyDown(KeyCode.A) && gameManager.playerTurn == 1){
            v3.x -= 10;
            playerMove();
            transform.position = v3;
            }

        if(Input.GetKeyDown(KeyCode.E) && gameManager.playerTurn == 1){
            Instantiate(bullet,transform.position,bullet.transform.rotation);
            gameManager.playerTurn = loopJump;
            //gameManager.wait(1);
            gameManager.StartCoroutine(gameManager.whoTurn(1));}
    }

    public void playerMove() {
        gameManager.playerTurn = loopJump;
        //gameManager.wait(1);
        gameManager.StartCoroutine(gameManager.whoTurn(1));
    }

        private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("PowerUp")) {
            bayesPieces++;
            Destroy(other.gameObject); }
    }
}

