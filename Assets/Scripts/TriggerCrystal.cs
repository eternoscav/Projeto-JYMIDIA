using UnityEngine;
using System.Collections;

public class TriggerCrystal : MonoBehaviour {
	public SwipeMotions player;
	public GameObject power;
	public TrocaRoupa roupa;

	public int cont=0;
	public int cont2 = 0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter(Collider other){
		//LiberarPorta.SetActive(false);


		if(other.tag == "Player"){
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
			p.RecolherCrystal(1);
			power.SetActive(true);
			Destroy (gameObject);
			Debug.Log("RELOU");
			roupa.enabled = true;

			
			
			
		}
		
	}
}

