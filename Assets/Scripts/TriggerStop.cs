using UnityEngine;
using System.Collections;

public class TriggerStop : MonoBehaviour {
	public Rotation2 rotation;

	void OnTriggerEnter(Collider other){
		if(other.tag == "Jogador"){
			rotation.enabled = false;
//			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
//			p.Morte();

			
		}
		
	}
}
