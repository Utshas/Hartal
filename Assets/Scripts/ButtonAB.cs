using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAB : MonoBehaviour {
	public Button ab;
	// Use this for initialization
	void Start () {
		Button btn = ab.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}
	void TaskOnClick(){
	}
	// Update is called once per frame
	void Update () {
		
	}
}
