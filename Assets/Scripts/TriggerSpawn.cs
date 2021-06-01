using UnityEngine;
using System.Collections;

public class TriggerSpawn : MonoBehaviour {
	public PlataformMoviment plataforma;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other){
		//Debug.Log (other.gameObject.name);
		if(other.tag == "Player"){
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
			plataforma.Speed = 0;
			p.Morte();
//			Destroy (gameObject);
		}
		
	}
}
