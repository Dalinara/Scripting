using UnityEngine;
using System.Collections;

public class Enum : MonoBehaviour 
{
	enum Direction {North, East, South, West}

	// Use this for initialization
	void Start () 
	{
		Direction myDirection;

		myDirection = Direction.North;

		myDirection = ReverseDirection (myDirection);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	Direction ReverseDirection(Direction dir)
	{
		if (dir == Direction.North)
			dir = Direction.South;

		return dir;
	}

}
