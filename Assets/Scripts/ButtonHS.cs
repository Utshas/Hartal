using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHS : MonoBehaviour {
	public Button hs;
	public int highscr;
	public Text hightext;
	// Use this for initialization
	void Start () {
		Button btn = hs.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}
	void TaskOnClick(){
		highscr=PlayerPrefs.GetInt("Player Score");
		hightext.text = " High Score: " + highscr.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
