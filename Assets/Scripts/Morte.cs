using UnityEngine;
using System.Collections;

public class Morte : MonoBehaviour {
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
			p.LigarFumaca = false;
			collider.enabled = false;
			StartCoroutine (time ());
			//			Destroy (gameObject);
		}
		
	}
		public IEnumerator time(){
		yield return new WaitForSeconds(3);
		collider.enabled = true;

		}
}
