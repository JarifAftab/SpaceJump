using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DPad : MonoBehaviour {
	
	
	
	
	public void moveRight(){
		neptuneController.sprite.velocity = new Vector2(4, neptuneController.sprite.velocity.y);
	}
	public void moveLeft(){
		neptuneController.sprite.velocity = new Vector2(-4, neptuneController.sprite.velocity.y);
	}
	public void jump(){
		
		if(neptuneController.onGround == true){
			neptuneController.bossJump = 0;
		}
		if(neptuneController.bossJump < 2){
		
			neptuneController.sprite.velocity = new Vector2(neptuneController.sprite.velocity.x, 6);
			neptuneController.bossJump++;
		
		}
	}
}
