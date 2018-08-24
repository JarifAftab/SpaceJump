using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ultraLevel : MonoBehaviour {
	
	public Button ultraLevelButton;
	public bool finishedLevel1;
	public bool finishedLevel2;
	public bool finishedLevel3;
	
	public bool noFailLevel1;
	public bool noFailLevel2;
	public bool noFailLevel3;
	
	public Sprite buttonImage;
	
	
	void Start(){
		

		
		ultraLevelButton.GetComponent<Button>().interactable = false;
		
	}
	
	void Update(){
		
		finishedLevel1 = Controller.levelComplete;
		finishedLevel2 = marsController.levelComplete;
		finishedLevel3 = jupiterController.levelComplete;
		
		noFailLevel1 = Controller.levelFailed;
		noFailLevel2 = marsController.levelFailed;
		noFailLevel3 = jupiterController.levelFailed;
		
		if((finishedLevel1 && noFailLevel1 == false )&& (finishedLevel2 && noFailLevel2 == false )&& (finishedLevel3 && noFailLevel3 == false)){
			
			 ultraLevelButton.GetComponent<Image>().sprite = buttonImage;
			 ultraLevelButton.GetComponent<Image>().color = Color.white;
			 ultraLevelButton.GetComponent<Button>().interactable = true;
		}
	}
	
}