//using UnityEngine;
//using System.Collections;
//
//public class gamestate : MonoBehaviour {
//	
//	// Declare properties
//	public static gamestate instance;
using UnityEngine;
using System.Collections;

public class gamestate : MonoBehaviour {
	
	// Declare properties
	public static gamestate instance;
	public string activeLevel;                     // Active level
	public int maxVidas;                                      // Max HP
	public int maxFrutas;                                      // Map MP
	public int vidas;                                         // Current HP
	public int frutas;                                         // Current MP
	public bool PlayerGirl;
	public bool PlayerSpecial;
	public bool PlayerBoy;
	

	public static gamestate Instance
	{
		get
		{
			if(instance == null)
			{
				instance = new GameObject("gamestate").AddComponent<gamestate> ();
			}
			
			return instance;
		}
	}      
	
	// Sets the instance to null when the application quits
	public void OnApplicationQuit()
	{
		instance = null;
	}

	public void startState()
	{
		print ("CRIANDO UM NOVO ESTADO DE GAMES");
		
		// Set default properties:
		activeLevel = "Level 1";
		name = "ESTADO JOGO";
		maxVidas = 2;
		maxFrutas = 0;
		vidas = maxVidas;
		frutas = maxFrutas;
		//PlayerBoy = true;
		//PlayerGirl = true;
		//PlayerSpecial = true;

		
		// Load level 1
		Application.LoadLevel("LEVEL01");
	}
	

	public string getLevel()
	{
		return activeLevel;
	}
	

	public void setLevel(string newLevel)
	{
		// Set activeLevel to newLevel
		activeLevel = newLevel;
	}
	

	public string getName()
	{
		return name;
	}

	public int getHP()
	{
		return vidas;
	}

	public int getMP()
	{
		return frutas;
	}
}