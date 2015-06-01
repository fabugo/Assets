using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	public float speed;
	public float speedTurn;
	public bool canMove;
	public Vector2 target;
	public Transform origin;
	public Transform signal;
	//public transform destiny;
	// Use this for initialization
	private void Start () {
		canMove = true;
	}
	
	// Update is called once per frame
	private void FixedUpdate () {
		if (canMove){
			transform.position = Vector3.MoveTowards(transform.position, target, speed);
			//lookat2d
		}
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Signal"))
			VerifyColor();
		if(other.gameObject.CompareTag("Car"))
        	canMove = false;
		if(other.gameObject.CompareTag("Out"))
			Destroy(this.gameObject);
    }

	private void OnTriggerExit2D(Collider2D other) {
		if(other.gameObject.CompareTag("Car"))
        	canMove = true;
    }

	private void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.CompareTag("Signal"))
			VerifyColor();
	}


	private void VerifyColor(){
		if(signal.GetComponent<SpriteRenderer>().color == new Color (255,0,0)){
			canMove = false;
		}else if(signal.GetComponent<SpriteRenderer>().color == new Color (0,255,0)){
			canMove = true;
		}
	}

}
