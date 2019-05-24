using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalScript : MonoBehaviour {

    public GameManager gameManager;

    void OnCollisionEnter(){
        
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
