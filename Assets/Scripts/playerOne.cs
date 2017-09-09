using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerOne : MonoBehaviour {

	public GameObject ball;
	private Transform ballTransform;
	public KeyCode front, back, left, right, jump;

	private float temPosX,temPosY,temPosZ,initialPosZ;
	Vector3 ballPosition;
	public float speed = 0;
	public float speed2 = 0;
	public Text scoreText;

	void Start () {
		ballTransform = ball.transform;
		ballPosition = new Vector3 (0f, 0f, 0f);
		initialPosZ = ballTransform.position.z;
	}
	

	void Update () {
		
		speed = (ballTransform.position.z-initialPosZ)/100;
		speed2 = speed + 26f;
		Debug.Log (speed);
		temPosZ = ballTransform.position.z + Time.deltaTime * (speed2);
		ballPosition = new Vector3 (ballTransform.position.x, ballTransform.position.y, temPosZ);
		ball.transform.position = ballPosition;
	}
}
