using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 ballToPaddleVector;
	private bool ballFired = false;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		ballToPaddleVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!ballFired) {
			this.transform.position = paddle.transform.position + ballToPaddleVector;
			if (Input.GetMouseButtonDown(0)) {
				print ("Mouse clicked");
				ballFired = true;
				this.rigidbody2D.velocity = new Vector2(6.0f, 6.0f);
			}
		}
	}
}
