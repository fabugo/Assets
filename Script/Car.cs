using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
	public float speed,speedTurn;
	public bool canMove;
	public Transform origin,fate;

	private void Start () {
		canMove = true;
	}

	private void FixedUpdate () {
		if (canMove){
			transform.position = Vector3.MoveTowards(transform.position, fate.position, speed);
			float AngleRad = Mathf.Atan2(fate.position.x - transform.position.x , fate.position.y - transform.position.y);
			float AngleDeg = (180 / Mathf.PI) * AngleRad;
			this.transform.rotation = Quaternion.Euler(0, 0, -AngleDeg);

			RaycastHit2D hit = Physics2D.Raycast(transform.position, fate.position);
			if(hit.distance > 0)
				Debug.Log(hit.distance);
			Debug.DrawRay(transform.position,fate.position);
		}

	}

	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Signal"))
			VerifyColor(other);
		if(other.gameObject.CompareTag("Car"))
        	canMove = false;
		if(other.gameObject.CompareTag("Out"))
			Destroy(this.gameObject);
		if(other.gameObject.CompareTag("redLight"))
			canMove = false;
		if (other.gameObject.CompareTag("yellowLight"))
			canMove = false;
    }

	private void OnTriggerExit2D(Collider2D other) {
//		if(other.gameObject.CompareTag("Car"))
//       	canMove = true;
    }

	private void OnTriggerStay2D(Collider2D other){
		if(other.gameObject.CompareTag("Signal"))
			VerifyColor(other);
		if (other.gameObject.CompareTag("greenLight"))
			canMove = true;


	}

	private void VerifyColor(Collider2D other){
		if(other.GetComponent<SpriteRenderer>().color == Color.red){
			canMove = false;
		}else if(other.GetComponent<SpriteRenderer>().color == Color.green){
			canMove = true;
		}
	}
}
