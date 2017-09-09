using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextBlock : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Debug.Log ("Trigger");
		BlockManager.mBlockManager.Instantiate ();
	}
}
