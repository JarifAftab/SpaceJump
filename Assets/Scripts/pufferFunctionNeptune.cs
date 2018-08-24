using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pufferFunctionNeptune : MonoBehaviour {
	
	public GameObject pufferFish;
	
	void Start(){
		
	}
	
	void Update(){
		
		if(neptuneController.sprite.position.x - pufferFish.GetComponent<Rigidbody2D>().position.x >-2 && neptuneController.sprite.position.x - pufferFish.GetComponent<Rigidbody2D>().position.x < 2 ){
		
			pufferFish.transform.localScale = new Vector3(1.6f,1.6f,1);
		
		}
		else if(neptuneController.sprite.position.x - pufferFish.GetComponent<Rigidbody2D>().position.x > 2){
			pufferFish.transform.localScale = new Vector3(1,1,1);
		}
		
	}
	
}
