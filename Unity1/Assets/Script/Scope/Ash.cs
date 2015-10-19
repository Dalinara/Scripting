using UnityEngine;
using System.Collections;

public class Ash : MonoBehaviour 
{
	public string pokedex;

	private int pokeball;
	private int potion;

	public int pokemon = 2;

	public StarterPokemon bag;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			Pokemon();
		}	
		
	}

	void Pokemon ()
	{
		bag = new StarterPokemon();
		bag.Pokeball(pokemon);
		pokemon--;
	}

	//Pokeball

}
