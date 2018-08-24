using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossController : MonoBehaviour {
	public  Rigidbody2D Boss;
	public double move;
	public int defeat;
	
	
	// Use this for initialization
	void Start () {
		move = Random.Range(0, 100);
		defeat = 100;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(neptuneController.inFinish == true){
			
			
			if(move >= 0 && move <= 33){
				Boss.velocity = new Vector2(-7, Boss.velocity.y);
				if(Boss.position.x < 52){
					Boss.transform.localScale = new Vector3(1.702114f,1.720032f,1);
					move = Random.Range(0, 100);
					
				}
				
			}
			else if(move > 33 && move <= 66){
				Boss.velocity = new Vector2(7, Boss.velocity.y);
				if(Boss.position.x > 63){
					Boss.transform.localScale = new Vector3(1.702114f,1.720032f,1);
					move = Random.Range(0, 100);
					
				}
			}
			else{
				
				Boss.transform.localScale = new Vector3(2.4f,2.4f,1);
				move = Random.Range(0, 100);
				defeat-=2;
				
				
			}
			if(defeat == 0){
				
				Destroy(Boss);
				neptuneController.nextScene = "MainMenu";
				
				Controller.levelFailed = false;
				Controller.levelComplete = false;
		
				marsController.levelFailed = false;
				marsController.levelComplete = false;
		
				jupiterController.levelFailed = false;
				jupiterController.levelComplete = false;
				
				Controller.returnScene = "False";
				marsController.returnScene = "False";
				jupiterController.returnScene = "False";
				neptuneController.returnScene = "False";
		
				Controller.nextScene = "False";
				marsController.nextScene = "False";
				jupiterController.nextScene = "False";
				neptuneController.nextScene = "False";
				
				SceneManager.LoadScene("Win");
				
				
				
				
			}
		}
	}
}
