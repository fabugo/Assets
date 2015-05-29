using UnityEngine;
using System.Collections;

public class In : MonoBehaviour {
	public Transform prefabCar;
	private int countCar;
	// Use this for initialization
	void Start () {
		countCar = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (countCar <= 5){
			Instantiate (prefabCar,transform.position,Quaternion.identity);
			countCar++;
		}
	}
}
