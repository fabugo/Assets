using UnityEngine;
using System.Collections;

public class In : MonoBehaviour {

	public int maxCar;
	public Transform fate;
	public Transform prefabCar;
	public int sleepTime;

	private int countCar;
	private int intTime;
	private int antRepeat;

	void Start () {
		countCar = 0;
		antRepeat = -1;
	}

	void Update () {
		intTime = (int) Time.time;
		if(intTime % sleepTime == 0 && intTime != antRepeat){
			antRepeat = intTime;
			if (countCar <= maxCar - 1){
				prefabCar.GetComponent<Car>().fate = this.fate;
				prefabCar.GetComponent<Car>().origin = this.transform;
				Instantiate (prefabCar,transform.position,Quaternion.identity);
				countCar++;
			}
		}
	}

	public void UnderCountCar(){
		countCar--;
	}
}
