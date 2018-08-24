using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Collisions : MonoBehaviour {

	 void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "Sprite_01")
        {
            print("Its working");
        }
    }
	

}