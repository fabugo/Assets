using UnityEngine;
using System.Collections;

public class Signal : MonoBehaviour {

	public int timeLeft; // time in seconds
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
		if(intTime % timeLeft == 0 && intTime != antRepeat){
			antRepeat = intTime;
			if(!isRed){
				gameObject.GetComponent<SpriteRenderer>().color = new Color (255,0,0);
				isRed = true;
			}else{
				gameObject.GetComponent<SpriteRenderer>().color = new Color (0,255,0);
				isRed = false;
			}
		}
	}
}
