using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	public float speed;
	public float speedTurn;
	public bool canMove;
	public transform destiny;
	// Use this for initialization
	void Start () {
		canMove = true;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (canMove)
			transform.Translate(new Vector3(-1f * Time.deltaTime * speed,0f,0f));
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Signal"))
        	canMove = false;
		if(other.gameObject.CompareTag("Car"))
        	canMove = false;
    }

    void OnTriggerExit2D(Collider2D other) {
		if(other.gameObject.CompareTag("Signal"))
        	canMove = true;
		if(other.gameObject.CompareTag("Car"))
        	canMove = true;
    }

}
