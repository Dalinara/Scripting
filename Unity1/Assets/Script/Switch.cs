using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour 
{
	public int intelligence = 2;

	// Use this for initialization
	void Start () 
	{
		Greet ();
	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}

	void Greet()
	{
		switch(intelligence)
		{
		case 2:
			print ("Hello!");
			break;
		case 1:
			print ("blargh!");
			break;
		default:
			print ("Incorrect incorrect level.");
			break;
		}


	}



}
