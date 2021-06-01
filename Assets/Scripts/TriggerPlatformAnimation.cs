using UnityEngine;
using System.Collections;

public class TriggerPlatformAnimation : MonoBehaviour {
	public GameObject fumaca;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other){
		//Debug.Log (other.gameObject.name);
		if (other.tag == "Player") {
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions> ();
						if(p.Correr == true) {
						
						p.Fumaca.SetActive (true);
				}
			//p.LigarFumaca = true;
//			animation.Stop ();
//			animation.Blend ("Running");
			//			Destroy (gameObject);
		}
		
	}
	void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
		//	fumaca.SetActive(false);
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
			p.Fumaca.SetActive(false);
			//p.LigarFumaca = false;
//			Debug.Log("FUMACA DESLIGA");
		}    
	}
}
