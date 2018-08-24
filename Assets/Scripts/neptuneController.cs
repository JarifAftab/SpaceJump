using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class neptuneController : MonoBehaviour {
//This intilizes the sprites rigid body object
	public static Rigidbody2D sprite;
	public Transform groundCheck;
	public Transform enemyCheck;
	public Transform enemyCheck2;
	public Transform enemyCheck3;
	public Transform enemyCheck4;
	public Transform enemyCheck5;
	public Transform enemyCheck6;
	public float groundCheckRadius;
	public float enemyCheckRadius;
	public float finishCheckRadius;
	public LayerMask whatIsGround;
	public LayerMask whatIsFast;
	public LayerMask whatIsEnemy;
	public LayerMask whatisFinish;
	public static bool onGround;
	public bool onFast;
	public bool onFinish;
	public bool onEnemy;
	public bool onEnemy2;
	public bool onEnemy3;
	public bool onEnemy4;
	public bool onEnemy5;
	public bool onEnemy6;
	public int jumpCount;
	public static string returnScene;
	public static string nextScene;
	public static bool inFinish;
	public Text bossText;
	
	public static int bossJump;
	
	
	public Button up;
	public Button right;
	public Button left;
	
	
	// Use this for initialization
	void Start () {
		//Actually access the array list of rigid bodies
		sprite=GetComponent<Rigidbody2D>();
		jumpCount = 0;
		inFinish = false;
		bossJump = 0;
		bossText.GetComponent<Text>().color = new Color(255,0,0,0);
		

	}
	
	// Update is called once per frame
	void Update () {
		//Since this is a rigid body, it has a velocity compnent of physics, this access the x value and gives it a constant by creating a Velcity 2d object
		if(inFinish == false){
			
			sprite.velocity = new Vector2(6, sprite.velocity.y);
			
		}
	
		onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
		onFast = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsFast);
		onEnemy = Physics2D.OverlapCircle(enemyCheck.position, enemyCheckRadius, whatIsEnemy);
		onEnemy2 = Physics2D.OverlapCircle(enemyCheck2.position, enemyCheckRadius, whatIsEnemy);
		onEnemy3 = Physics2D.OverlapCircle(enemyCheck3.position, enemyCheckRadius, whatIsEnemy);
		onEnemy4 = Physics2D.OverlapCircle(enemyCheck4.position, enemyCheckRadius, whatIsEnemy);
		onEnemy5 = Physics2D.OverlapCircle(enemyCheck5.position, enemyCheckRadius, whatIsEnemy);
		onEnemy6 = Physics2D.OverlapCircle(enemyCheck6.position, enemyCheckRadius, whatIsEnemy);
		onFinish = Physics2D.OverlapCircle(groundCheck.position, finishCheckRadius, whatisFinish);
		
		if(sprite.position.y < -50 || onEnemy || onEnemy2 || onEnemy3 || onEnemy4 || onEnemy6|| onEnemy5){
			returnScene = "planetSelect";
			Controller.levelFailed = false;
			Controller.levelComplete = false;
		
			marsController.levelFailed = false;
			marsController.levelComplete = false;
		
			jupiterController.levelFailed = false;
			jupiterController.levelComplete = false;
			
			
			SceneManager.LoadScene ("Lose");
			
			
			
		}
		
		if(onFinish){
			
			bossFight();
			
		}
		
		if((onGround || onFast) && inFinish == false){
				jumpCount = 0;
				if(onFast){
					sprite.velocity = new Vector2(10, sprite.velocity.y);
				}
			}
		
		if(Input.GetMouseButtonDown(0) && inFinish == false){
			
			if(jumpCount < 1){
				
				if(onFast){
					sprite.velocity = new Vector2(sprite.velocity.x,10);
				}
				
				else{
				
					sprite.velocity = new Vector2(sprite.velocity.x,5);
		
				}
				jumpCount++;
			}
			
			
		}
			
			
			
			

		
		
	}
	public void bossFight(){
			inFinish = true;
			up.GetComponent<Button>().interactable = true;
			right.GetComponent<Button>().interactable = true;
			left.GetComponent<Button>().interactable = true;
			bossText.GetComponent<Text>().color = new Color(255,0,0,1);
			sprite.position = new Vector3(51.84f,23.28f,0);
			sprite.velocity = new Vector2(0, sprite.velocity.y);
	}
}
