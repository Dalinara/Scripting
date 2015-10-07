using UnityEngine;
using System.Collections;

public class For : MonoBehaviour 
{
	int numEnemies = 3;
	// Use this for initialization
	void Start () 
	{
		//Add more enemies
		for (int i = 1; i < numEnemies; i++) {
			Debug.Log("Creating enemy number:" + i);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
