using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		void OnTriggerStay (Collider other){
		if(other.tag == "Poder"){
			Debug.Log ("Relou");
		Destroy(other.gameObject);
	}

	}
}