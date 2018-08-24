using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {
	//This intilizes the sprites rigid body object
	public Rigidbody2D sprite;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	public bool onGround;
	public int jumpCount;
	public static string returnScene;
	public static string nextScene;
	public static bool levelComplete = false;
	public static bool levelFailed = false;
	

	// Use this for initialization
	void Start () {
		//Actually access the array list of rigid bodies
		sprite=GetComponent<Rigidbody2D>();
		jumpCount = 0;
		

	}
	
	// Update is called once per frame
	void Update () {
		//Since this is a rigid body, it has a velocity compnent of physics, this access the x value and gives it a constant by creating a Velcity 2d object

		sprite.velocity = new Vector2(3, sprite.velocity.y);
		onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
		
		if(sprite.position.y < -50){
			returnScene = "Level 1";
			levelFailed	= true;		
			SceneManager.LoadScene ("Lose");
			
			
		}
		
		if(sprite.position.x >= 59.8 && sprite.position.y >= 0.68){
			nextScene = "Level 2";
			levelComplete = true;
			SceneManager.LoadScene ("Win");
		}
		
		if(onGround){
				jumpCount = 0;
			}
		
		if(Input.GetMouseButtonDown(0)){
			
			if(jumpCount < 1){
				sprite.velocity = new Vector2(sprite.velocity.x,5);
				jumpCount++;
			}
			
			
		}
		

		
		
	}
	
}
