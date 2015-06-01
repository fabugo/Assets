using UnityEngine;
using System.Collections;

public class In : MonoBehaviour {
	public int maxCar;
	public Transform outCar;
	public Transform signal;
	public Transform prefabCar;
	public int sleepTime;

	private int countCar;
	private int intTime;
	private int antRepeat;
	// Use this for initialization
	void Start () {
		countCar = 0;
		antRepeat = -1;
	}
	
	// Update is called once per frame
	void Update () {
		intTime = (int) Time.time;
		if(intTime % sleepTime == 0 && intTime != antRepeat){
			antRepeat = intTime;
			if (countCar <= maxCar - 1){
				prefabCar.GetComponent<Car>().origin = this.transform;
				prefabCar.GetComponent<Car>().signal = this.signal;
				prefabCar.GetComponent<Car>().target = outCar.position;
				Instantiate (prefabCar,transform.position,Quaternion.identity);
				countCar++;
			}
		}
	}

	public void UnderCountCar(){
		countCar--;
	}
}
