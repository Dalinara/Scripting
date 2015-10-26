using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{
	public Rigidbody bulletPrefab;
	public Transform firePosition;
	public float bulletSpeed = 1000f;
	
	
	private Inventory inventory;
	
	
	void Awake ()
	{
		inventory = GetComponent<Inventory>();
	}
	
	
	void Update ()
	{
		Shoot();
	}
	
	
	void Shoot ()
	{
		if(Input.GetKeyDown(KeyCode.X) && inventory.myStuff.bullets > 0)
		{
			Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
			bulletInstance.AddForce(firePosition.forward * bulletSpeed);
			inventory.myStuff.bullets--;
		}
	}
}