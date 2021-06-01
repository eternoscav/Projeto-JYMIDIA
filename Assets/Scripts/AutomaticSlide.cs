using UnityEngine;
using System.Collections;

public class AutomaticSlide : MonoBehaviour {
	public GameObject FingerDown;
	public SwipeMotions swipe;

	void OnTriggerEnter(Collider other){
//		Debug.Log ("Escorregar");
		if(other.tag == "Player"){

			StartCoroutine (Automatic ());


			
		}

		
	}
	public IEnumerator Automatic ()
	{	

		FingerDown.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		swipe.Shrink ();
		yield return new WaitForSeconds (0.8f);
		FingerDown.SetActive (false);
//		SwipeMotions p = gameObject.GetComponent<SwipeMotions>();
//		p.Shrink();
	}
}
