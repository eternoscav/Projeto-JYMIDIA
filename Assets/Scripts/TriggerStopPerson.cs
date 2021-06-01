using UnityEngine;
using System.Collections;

public class TriggerStopPerson : MonoBehaviour {
	public SwipeMotions stop;
	public GameObject colisor;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider other){
		//Debug.Log (other.gameObject.name);
		if(other.tag == "Player"){
			stop.PersonSpeed = 0;
			colisor.SetActive (false);

		//				Destroy (gameObject);
		}
		
	}
}
