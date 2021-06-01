
using UnityEngine;
using System.Collections;

public class Oncollider : MonoBehaviour {

	void Start (){
		}

	IEnumerator OnCollisionStay(Collision collision){
		if(collision.gameObject.tag.Equals("ground") || collision.gameObject.layer.Equals ("Plat")){
			//Destroy (collision.gameObject);
			collision.collider.enabled = false;
			yield return new WaitForSeconds (2);
			collision.collider.enabled = true;
			Debug.Log("COLISOR_ESTA");  
		}

	}
	IEnumerator OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag.Equals("ground") || collision.gameObject.layer.Equals ("Plat")){
		//	Destroy (collision.gameObject);
			collision.collider.enabled = false;
			yield return new WaitForSeconds (2);
			collision.collider.enabled = true;
			Debug.Log("COLISOR_ENTROU");  
			//collision.collider.enabled = true;

		}
	}
	IEnumerator OnCollisionExit(Collision collision){
		if(collision.gameObject.tag.Equals("ground") || collision.gameObject.layer.Equals ("Plat")){
		//	Destroy (collision.gameObject);
			collision.collider.enabled = false;
			yield return new WaitForSeconds (2);
			collision.collider.enabled = true;
			Debug.Log("COLISOR_SAIU");  
		}
	}

	
	
}