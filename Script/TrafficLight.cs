using UnityEngine;
using System.Collections;

public class TrafficLight : MonoBehaviour {
	
	public int stats; // 0 = verde, 1 = yellow, 2 = red
	public float initialValue = 15;
	public float timer;
	// Use this for initialization
	void Start () {
		timer = initialValue;
		stats = 0;
		gameObject.tag = "greenLight";
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer <= 0 && stats == 0) {
			gameObject.tag = "yellowLight";
			stats = 1;
			timer = 5;
		}

		if (timer <= 0 && stats == 1) {
			gameObject.tag = "redLight";
			stats = 2;
			timer = initialValue+5;
		}

		if (timer <= 0 && stats == 2) {
			gameObject.tag = "greenLight";
			stats = 0;
			timer = initialValue;
		}
	}
}
