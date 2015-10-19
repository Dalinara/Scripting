using UnityEngine;
using System.Collections;

public class StarterPokemon : MonoBehaviour 
{

	// Use this for initialization
	public void Pokeball (int pokemon = 2)
	{
		if (pokemon > 1) 
		{
			Debug.Log ("Congratulations! You have gotten a Charmander!");
			pokemon--;
		} 
		else if (pokemon > 0) 
		{
			print("Congratulations! You have gotten a Pikachu!");
			pokemon--;
		}
		else
		{
			print ("Sorry, there are no more pokemon.");
		}
	}
}
