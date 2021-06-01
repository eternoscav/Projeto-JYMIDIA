using UnityEngine;
using System.Collections;

public class TriggerFase : MonoBehaviour {
	public GameObject Ativo;
	public GameObject Inativo;



	void OnTriggerEnter(Collider other){
		//LiberarPorta.SetActive(false);
		if(other.tag == "Player"){
			Ativo.SetActive (false);
			Inativo.SetActive (true);

			
		}
		
	}
}


