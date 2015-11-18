using UnityEngine;
using System.Collections;

public class Array02 : MonoBehaviour 
{
	public GameObject[] players;

	// Use this for initialization
	void Start () 
	{
		players = GameObject.FindGameObjectsWithTag ("Player");

		for(int i = 0; i < players.Length; i++)
		{
			Debug.Log("Player Number "+i+" is named "+players[i].name);
		}

	}

}
