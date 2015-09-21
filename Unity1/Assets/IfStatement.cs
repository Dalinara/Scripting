using UnityEngine;
using System.Collections;

public class IfStatement : MonoBehaviour 
{
	public float coffeeTemperature = 85.0f;
	public float hotLimitTemperature = 70.0f;
	public float coldLimitTemperature = 40.0f;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
			TemperatureTest ();

		coffeeTemperature -= Time.deltaTime * 5f;
	}

	void TemperatureTest()
	{
		//If the coffee's temperature is too hot.
		if (coffeeTemperature > hotLimitTemperature) 
		{
			print ("Coffee is too hot.");
		}
		//If the coffee's temperature is too cold.
		else if (coffeeTemperature < coldLimitTemperature) 
		{
			print ("Coffee is too cold.");
		}
		//If the temperature is neither too hot nor too cold.
		else 
		{
			print ("Coffee is just right.");
		}
	}
}