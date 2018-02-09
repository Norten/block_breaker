using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	private int timesHit;

	// Use this for initialization
	void Start () {
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (timesHit >= maxHits)
		{
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		timesHit++;
		SimulateWin();
	}

	// TODO Remove this method at the end of project
	void SimulateWin() {
		var levelManager = GameObject.FindObjectOfType<LevelManager>();
		levelManager.LoadNextLevel();
	}
}
