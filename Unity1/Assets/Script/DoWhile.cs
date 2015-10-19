using UnityEngine;
using System.Collections;

public class DoWhile : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		bool shouldContine = false;
		//Say Hello
		do {
			print ("Hello World");
		} while(shouldContine == true);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
