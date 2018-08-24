using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumpy : MonoBehaviour {
	public  Rigidbody2D jumpyS;
	public double vert;

	// Use this for initialization
	void Start () {
		vert = jumpyS.position.y;
		

	}

	// Update is called once per frame
	void Update () {
		
		
		if(jupiterController.sprite.position.x - jumpyS.position.x >-2 && jupiterController.sprite.position.x - jumpyS.position.x < 2 ){
			jumpyS.velocity = new Vector2(jumpyS.velocity.x,1);
		}
		else if(jupiterController.sprite.position.x - jumpyS.position.x >-1){
			jumpyS.velocity = new Vector2(jumpyS.velocity.x,-3);
			if(jumpyS.position.y <= vert){
				jumpyS.velocity = new Vector2(jumpyS.velocity.x,0);
			}
			
			
		}
	
		
	}
	 
}
