using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasHide : MonoBehaviour {
	public CanvasGroup hSView;
	public CanvasGroup abView;
	public CanvasGroup bkView;
	// Use this for initialization
	void Start () {
		hSView.alpha = 0f;
		hSView.blocksRaycasts = false;
		hSView.interactable = false;
		abView.alpha = 0f;
		abView.blocksRaycasts = false;
		abView.interactable = false;
		bkView.alpha = 0f;
		bkView.blocksRaycasts = false;
		bkView.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void showPanelHS(){
		hSView.alpha = 1f;
		hSView.blocksRaycasts = true;
		hSView.interactable = true;
		bkView.alpha = 1f;
		bkView.blocksRaycasts = true;
		bkView.interactable = true;
	}
	public void showPanelAB(){
		abView.alpha = 1f;
		abView.blocksRaycasts = true;
		abView.interactable = true;
		bkView.alpha = 1f;
		bkView.blocksRaycasts = true;
		bkView.interactable = true;
	}
	public void hidePanelHS(){
		hSView.alpha = 0f;
		hSView.blocksRaycasts = false;
		hSView.interactable = false;
		bkView.alpha = 0f;
		bkView.blocksRaycasts = false;
		bkView.interactable = false;
	}
	public void hidePanelAB(){
		abView.alpha = 0f;
		abView.blocksRaycasts = false;
		abView.interactable = false;
		bkView.alpha = 0f;
		bkView.blocksRaycasts = false;
		bkView.interactable = false;
	}
}
