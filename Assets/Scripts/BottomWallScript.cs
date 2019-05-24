using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomWallScript : MonoBehaviour {

    public GameManager gameManager;
    public GameObject ballPrefab;
    Vector3 placePosition = new Vector3(0f, 0.6f, -7f);

    void OnCollisionEnter(Collision col){
        Destroy(col.gameObject);
        if(gameManager.life > 0){
            Instantiate(ballPrefab, placePosition, Quaternion.identity);
            gameManager.life -= 1;
            //gameManager --;
        }
        else if(gameManager.life == 0){

            SceneManager.LoadScene("GameOver");
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
