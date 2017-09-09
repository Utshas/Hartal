using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {
	bool isPause;
	void Start(){
		isPause = false;
	}

	public void play(){
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Scene_One");
		Debug.Log ("Play");

	}

	public void quit(){
		Application.Quit ();
	}

	public void back(){
		SceneManager.LoadScene (0);
	}

	public void pause(){
		if (!isPause) {
			Time.timeScale = 0.0f;
			//gameObject.GetComponentsInChildren.<Text>.text= "Play";
			isPause = true;
		} else if (isPause) {
			Time.timeScale = 1.0f;
			isPause = false;
		}
	}
}
