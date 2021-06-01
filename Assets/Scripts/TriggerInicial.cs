using UnityEngine;
using System.Collections;

public class TriggerInicial : MonoBehaviour {
		
	void OnTriggerEnter(Collider other){
		//Debug.Log (other.gameObject.name);
		if(other.tag == "Player"){
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
			p.AnimacaoInicial();
			
			//			Destroy (gameObject);
		}
		
	}
}
