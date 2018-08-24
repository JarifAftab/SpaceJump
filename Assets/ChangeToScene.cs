using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToScene : MonoBehaviour {
	public string PreviousScene;
	public string marsPreviousScene;
	public string jupiterPreviousScene;
	public string neptunePreviousScene;
	public string NextScene;
	public string marsNextScene;
	public string jupiterNextScene;
	public string neptuneNextScene;
	/*public GameObject GetTheScene;
	public Controller getScene;
	*/
		
	
	public void changePreviouScene_Level1(){
		PreviousScene = Controller.returnScene;
		marsPreviousScene = marsController.returnScene;
		jupiterPreviousScene = jupiterController.returnScene;
		neptunePreviousScene = neptuneController.returnScene;
		
		if(PreviousScene == "Level 1"){
			Controller.returnScene = "False";
			SceneManager.LoadScene(PreviousScene);
			
		}
		
		else if(marsPreviousScene == "Level 2"){
			
			marsController.returnScene = "False";
			SceneManager.LoadScene(marsPreviousScene);
			
			
		}
		
		else if(jupiterPreviousScene == "Level 3"){
			jupiterController.returnScene = "False";
			SceneManager.LoadScene(jupiterPreviousScene);
			
			
		}
		else if(neptunePreviousScene == "planetSelect"){
			
			neptuneController.returnScene = "False";
			SceneManager.LoadScene(neptunePreviousScene);
			
			
		}
		
		
	}
	
	public void changeToNext(){
		NextScene = Controller.nextScene;
		marsNextScene = marsController.nextScene;
		jupiterNextScene = jupiterController.nextScene;
		neptuneNextScene = neptuneController.nextScene;
		if(NextScene == "Level 2"){
			SceneManager.LoadScene(NextScene);
			Controller.nextScene = "False";
		}
		else if(marsNextScene == "Level 3"){
			
			SceneManager.LoadScene(marsNextScene);
			marsController.nextScene = "False";
			
		}
		else if(jupiterNextScene == "planetSelect" ){
			SceneManager.LoadScene(jupiterNextScene);
			jupiterController.nextScene = "False";
		}
		else if(neptuneNextScene == "MainMenu"){
			
			SceneManager.LoadScene(neptuneNextScene);
			neptuneController.nextScene = "False";
			
		}
	}
}


