using UnityEngine;
using System.Collections;

public class AutomaticPower : MonoBehaviour {
	public GameObject FingerRight;
	public SwipeMotions swipe;
	
	void OnTriggerEnter(Collider other){
//		Debug.Log ("Escorregar");
		if(other.tag == "Player"){
			
			StartCoroutine (Automatic ());
			
			
			
		}
		
		
	}
	public IEnumerator Automatic ()
	{	
		
		FingerRight.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		swipe.MagiaRed ();
		yield return new WaitForSeconds (0.8f);
		FingerRight.SetActive (false);
		//		SwipeMotions p = gameObject.GetComponent<SwipeMotions>();
		//		p.Shrink();
	}
}
