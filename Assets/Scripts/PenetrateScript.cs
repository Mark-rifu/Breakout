using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenetrateScript : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter(){

        Destroy(gameObject);

        gameManager.score += 10;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
