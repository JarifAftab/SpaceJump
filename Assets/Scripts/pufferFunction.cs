using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pufferFunction : MonoBehaviour {
	
	public GameObject pufferFish;
	
	void Start(){
		
	}
	
	void Update(){
		
		if(jupiterController.sprite.position.x - pufferFish.GetComponent<Rigidbody2D>().position.x >-2 && jupiterController.sprite.position.x - pufferFish.GetComponent<Rigidbody2D>().position.x < 2 ){
		
			pufferFish.transform.localScale = new Vector3(1.6f,1.6f,1);
		
		}
		else if(jupiterController.sprite.position.x - pufferFish.GetComponent<Rigidbody2D>().position.x > 2){
			pufferFish.transform.localScale = new Vector3(1,1,1);
		}
		
	}
	
}

