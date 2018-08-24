using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public void launchGame(){
		
		SceneManager.LoadScene("planetSelect");
		
	}
	public void launchPlanet(){
		SceneManager.LoadScene("Level 1");
	}
	public void launchPlanet2(){
		SceneManager.LoadScene("Level 2");
	}
	
	public void launchPlanet3(){
		SceneManager.LoadScene("Level 3");
	}
	
	public void launchPlanet4(){
		
		SceneManager.LoadScene ("Level 4");
		
	}
	public void quitGame(){
		
		Application.Quit();
		
	}
	
	public void returnMenu(){
		Controller.returnScene = "False";
		marsController.returnScene = "False";
		jupiterController.returnScene = "False";
		neptuneController.returnScene = "False";
		
		Controller.nextScene = "False";
		marsController.nextScene = "False";
		jupiterController.nextScene = "False";
		neptuneController.nextScene = "False";
		
		SceneManager.LoadScene("MainMenu");
		
	}
	
	public void helpMenu(){
		
		SceneManager.LoadScene("Help");
	}
	public void resetProgress(){
		
		Controller.levelFailed = false;
		Controller.levelComplete = false;
		
		marsController.levelFailed = false;
		marsController.levelComplete = false;
		
		jupiterController.levelFailed = false;
		jupiterController.levelComplete = false;
		
	}
	
}
