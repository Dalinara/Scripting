using UnityEngine;
using System.Collections;

public class While : MonoBehaviour 
{
	public int cupsInSink = 4;

	// Use this for initialization
	void Start () 
	{
		//Wash the cups
		while (cupsInSink > 0) {
			Debug.Log ("I've washed a cup!");
			cupsInSink--;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
