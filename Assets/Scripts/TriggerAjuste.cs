using UnityEngine;
using System.Collections;

public class TriggerAjuste : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		//Debug.Log (other.gameObject.name);
		if(other.tag == "Player"){
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
			Debug.Log ("RELOU AJUSTE");
			p.Ajuste();

			//StartCoroutine (time ());
			//			Destroy (gameObject);
		}
		
	}
	public IEnumerator time(){
		yield return new WaitForSeconds(2);
		collider.enabled = true;
		
	}
}
