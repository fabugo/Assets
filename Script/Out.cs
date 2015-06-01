using UnityEngine;
using System.Collections;

public class Out : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Transform originCar = other.GetComponent<Car>().origin;
		originCar.GetComponent<In>().UnderCountCar();
	}
}
