using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neptuneArcher : MonoBehaviour {
	public  Rigidbody2D Archer;
	public Sprite bulletSprite;
	public bool bulletDrop = false;
	public double travelD;
	public GameObject other;
	// Use this for initialization
	void Start () {
		other = new GameObject();
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if(neptuneController.sprite.position.x - Archer.position.x >-4 && neptuneController.sprite.position.x - Archer.position.x < 4 && bulletDrop == false ){
			
			bulletDrop = true;
			other.AddComponent<SpriteRenderer>();
			other.AddComponent<Rigidbody2D>();
			other.AddComponent<BoxCollider2D>();
			other.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
			other.layer = 10;
			other.transform.localScale = new Vector3(0.1f,0.1f,1);
			Vector2 tempColl = new Vector2(2,2);
			other.GetComponent<BoxCollider2D>().size = tempColl;
			Vector3 temp = new Vector3(Archer.position.x,Archer.position.y,0);
			other.transform.position = temp;
			travelD = other.transform.position.x;
			other.GetComponent<SpriteRenderer>().sprite = bulletSprite;
			other.GetComponent<Rigidbody2D>().velocity = new Vector2(-3, other.GetComponent<Rigidbody2D>().velocity.y);
			
			
		}
		
		if(other.transform.position.x - travelD > 4 || other.transform.position.x - travelD < -4){
				Destroy(other.GetComponent<SpriteRenderer>());
				Destroy(other.GetComponent<BoxCollider2D>());
				Destroy(other.GetComponent<Rigidbody2D>());
				bulletDrop = false;
			}

		
		
	}
}
