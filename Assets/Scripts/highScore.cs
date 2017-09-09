using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScore : MonoBehaviour {

	public int highscr;
	public Text hightext;

	// Use this for initialization
	void Start () {

		highscr=PlayerPrefs.GetInt("Player Score");
		hightext.text = " High Score: " + highscr.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
