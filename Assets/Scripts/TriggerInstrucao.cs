using UnityEngine;
using System.Collections;

public class TriggerInstrucao : MonoBehaviour {
	public GameObject Controls;
	public GameObject Interface;
	public GameObject TriggerAutomatic;
	void Start(){
		}

	void OnTriggerEnter(Collider other){
	if(other.tag == "Player"){
			Interface.SetActive (true);
			Controls.SetActive (true);
			TriggerAutomatic.SetActive (false);
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
			p.DesligarInstrucao = false;
			p.TouchLigar = true;
			
			//			Destroy (gameObject);
		}
		
	}
}
