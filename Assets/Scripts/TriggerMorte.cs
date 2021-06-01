using UnityEngine;
using System.Collections;

public class TriggerMorte : MonoBehaviour {

	
	void OnTriggerEnter(Collider other){

		if(other.tag == "Player"){
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
			p.Morte();
			Debug.Log ("INIMIGO MORTE");
			//Destroy (gameObject);
		//	GetComponent<BoxCollider> ().enabled = false;
		//	StartCoroutine (color ());
			
			
		}
		
	}
//	public IEnumerator color(){
//		yield return new WaitForSeconds(1);
//		Destroy (gameObject);
//	}
}
