using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour{
	
    public Button exitButton;
	public bool del = false;
	
    public void PauseGame()
    {
        if(!del){
			Time.timeScale = 0;
			exitButton.GetComponent<Button>().interactable = true;
			del = true;
		}
		else{
			Time.timeScale = 1;
			exitButton.GetComponent<Button>().interactable = false;
			del = false;
		}
    } 
	
	public void leaveButtonPause(){
		Time.timeScale = 1;
		SceneManager.LoadScene("planetSelect");
		
	}
  
}


