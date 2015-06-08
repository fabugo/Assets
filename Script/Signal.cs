using UnityEngine;
using System.Collections;

public class Signal : MonoBehaviour {
	public int sleep; // time in seconds
	private int intTime;
	public bool isRed;
	private int antRepeat;
	// Use this for initialization
	void Start () {
		antRepeat = -1;
	}
	
	// Update is called once per frame
	void Update() {
		intTime = (int) Time.time;
		if(intTime % sleep == 0 && intTime != antRepeat){
			antRepeat = intTime;
			if(!isRed){
				gameObject.GetComponent<SpriteRenderer>().color = Color.red;
				isRed = true;
			}else{
				gameObject.GetComponent<SpriteRenderer>().color = Color.green;
				isRed = false;
			}
		}
	}

}
