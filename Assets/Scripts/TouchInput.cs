using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchInput : MonoBehaviour, IPointerDownHandler, IDragHandler{

	public float sensivity = 1;
	public int count = 0, position = 0, moveL, moveR;
	public GameObject ball;
	private Transform ballTransform;

	private float temPosX,temPosY,temPosZ;
	Vector3 ballPosition,jump_v;
	private Vector2 initialPos;
	// Use this for initialization
	void Start () {
		ballTransform = ball.transform;
		ballPosition = new Vector3 (0f, 0f, 0f);
		if (gameObject.GetComponents<EventTrigger> () == null)
			gameObject.AddComponent<EventTrigger> ();
	}
	public void OnPointerDown(PointerEventData eventData){
		initialPos = eventData.position;
		if (position == 0) {
			moveL = 1;
			moveR = 1;
		} else if (position == 1) {
			moveL = 1;
		} else if (position == -1) {
			moveR = 1;
		}
	}

	public void OnDrag (PointerEventData eventData){
		
		if (initialPos.x - sensivity > (eventData.position.x) && count != -1 && moveL == 1) {
				temPosX = ballTransform.position.x - 3f;
				ballPosition = new Vector3 (temPosX, ballTransform.position.y, ballTransform.position.z);
				ball.transform.position = ballPosition;
				Debug.Log ("Left");
				count--;
				moveL--;
				position--;
			} else if (initialPos.x + sensivity < (eventData.position.x) && count != 1 && moveR == 1) {
				temPosX = ballTransform.position.x + 3f;
				ballPosition = new Vector3 (temPosX, ballTransform.position.y, ballTransform.position.z);
				ball.transform.position = ballPosition;
				Debug.Log ("Right");
				count++;
				moveR--;
				position++;

			}

		}

	}
