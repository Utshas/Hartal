using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour {
	
	public float startDistance = 100;
	public float yDistance = 100;
	public float minSpread = 5;
	public float maxSpread = 10;
	public float minDistance=50;
	public int highscore;
	public Transform playerTransform;
	public GameObject[] obstaclePrefab;
	public Obstacle obj;
	float ySpread;
	float lastYPos;
	public int score = 0;
	public Text scoreT;
	public Text message;

	void Start(){
		ySpread = Random.Range(minSpread, maxSpread);
		lastYPos = playerTransform.position.z; //+ (startDistance - ySpread - yDistance);
		highscore=PlayerPrefs.GetInt("Player Score");
	}

	void Update () {
		GameObject clone;
		if(playerTransform.position.z - lastYPos > minDistance){
			int t = Random.Range (0,3);
			if (t == 2) {
				clone = (GameObject)Instantiate (obstaclePrefab [t], new Vector3 (playerTransform.position.x, 0, lastYPos + 110f), Quaternion.identity);
			} else {
				float lanePos = Random.Range (0, 3);
				lanePos = ((lanePos) * 3f) + 180f;
				clone = (GameObject)Instantiate (obstaclePrefab [t], new Vector3 (lanePos, 0, lastYPos + 110f), Quaternion.identity);
			}
			Destroy (clone, 20f);
			score++;
			scoreT.text = "Score: " + score.ToString ();
			//lastYPos += ySpread;
			lastYPos = playerTransform.position.z;
			ySpread = Random.Range(minSpread, maxSpread);
					if (score > highscore) {
				PlayerPrefs.SetInt("Player Score", score);
			}
		}
	}
}
