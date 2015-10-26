using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour 
{

	// Use this for initialization
	public class Stuff
	{
		public int bullets;

		//Parametized Constructer
		public Stuff(int bul)
		{
			bullets = bul;
		}

		//Constructor
		public Stuff()
		{
			bullets = 1;
		}

	}

	//Instance of the class
	public Stuff myStuff = new Stuff(50);

	void Start()
	{
		//Call the class
		Debug.Log (myStuff.bullets);
	}

}
