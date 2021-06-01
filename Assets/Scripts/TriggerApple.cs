using UnityEngine;
using System.Collections;

public class TriggerApple : MonoBehaviour {

	
	void OnTriggerEnter(Collider other){
		//Debug.Log (other.gameObject.name);
		if(other.tag == "Player"){
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
			p.RecolherMaca(1);
			Destroy (gameObject);
		//	GetComponent<BoxCollider> ().enabled = false;
		//	StartCoroutine (color ());
			
			
		}
		
	}
//	public IEnumerator color(){
//		yield return new WaitForSeconds(1);
//		Destroy (gameObject);
//	}
}
