using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTrans : MonoBehaviour {
	
	public Animator transition;
	public string sceneName = "MainMenu";
	
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(LoadScene());
	}
	
	IEnumerator LoadScene(){
		
		
		yield return new WaitForSeconds(2.5f);
		SceneManager.LoadScene(sceneName);
		
		
	}
}
