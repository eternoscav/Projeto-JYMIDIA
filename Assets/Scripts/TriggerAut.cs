using UnityEngine;
using System.Collections;

public class TriggerAut : MonoBehaviour {
	public PlataformMoviment plataform;
	//public bool IsGrounded = true; 

	void OnTriggerExit(Collider other){
		//Debug.Log (other.gameObject.name);
		if(other.tag == "Player"){
			plataform.enabled = false;
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
			//if(IsGrounded == true){
			p.AnimacaoFinal();
			//	IsGrounded = false;
			}
			//	parallax.enabled = false;
			//			Destroy (gameObject);
		}
		
	}
//}
