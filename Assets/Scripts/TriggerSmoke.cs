

using UnityEngine;
using System.Collections;

public class TriggerSmoke : MonoBehaviour {
	public SwipeMotions fumaca;
	//public CharacterController controller;

			 
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			fumaca.LigarFumaca = true;
			Debug.Log("ENTROU");
		}    
	}
	
	void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
			fumaca.LigarFumaca = false;
			Debug.Log("SAIU");
		}    
	}
	}