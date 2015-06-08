using UnityEngine;
using System.Collections;

public class Check : MonoBehaviour {
	public Transform next;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other) {
		if(other.gameObject.CompareTag("Car")){
			if(Random.Range(0,2) == 1)
				other.GetComponent<Car>().fate = next.transform;
		}
	}
}
