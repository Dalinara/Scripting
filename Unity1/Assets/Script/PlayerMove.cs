using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
	public float speed = 5f;
	public float turnSpeed = 10f;
	
	
	void Update ()
	{
		Movement();
	}
	
	
	void Movement ()
	{
		float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
		
		transform.Translate(Vector3.forward * forwardMovement);
		transform.Rotate(Vector3.up * turnMovement);
	}
}
