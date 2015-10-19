using UnityEngine;
using System.Collections;

public class IfStatement1 : MonoBehaviour 
{
	public float coffeeTemp = 85f;
	public float hotLimit = 70f;
	public float coldLimit = 40f;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
			TemperatureTest ();
		
		coffeeTemp -= Time.deltaTime * 5f;
	}
	
	void TemperatureTest()
	{
		if (coffeeTemp > hotLimit) 
		{
			print ("Coffee is too hot");
		} 
		else if (coffeeTemp < coldLimit) 
		{
			print ("Coffee is too cold");
		}
		else 
		{
			print ("Coffee is just right");
		}
	}
	
	
}
