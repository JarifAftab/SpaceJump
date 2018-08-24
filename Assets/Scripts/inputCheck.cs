using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputCheck : MonoBehaviour {

	public Text input;
	void Update(){
		if(input.text == "QueenJafifi"){
			
			Controller.levelFailed = false;
			Controller.levelComplete = true;
			
			marsController.levelFailed = false;
			marsController.levelComplete = true;
			
			jupiterController.levelFailed = false;
			jupiterController.levelComplete = true;
			
		}
	}
}
