using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Visibility : MonoBehaviour {
	public static Visibility vs;
	public Text message;
	public Button pauseButton;

	void OnTriggerEnter(Collider other){
		Time.timeScale = 0.0f;
		pauseButton.enabled = false;
		message.text = "Finished!";
	}
}
