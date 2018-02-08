using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		var paddlePos = gameObject.transform.position;
		mousePosInBlocks = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
		gameObject.transform.position = new Vector3(mousePosInBlocks, paddlePos.y, paddlePos.z);
	}
}
