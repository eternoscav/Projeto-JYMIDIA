using UnityEngine;
using System.Collections;

public class AutomaticJump : MonoBehaviour {
	public GameObject FingerJump;
	public SwipeMotions swipe;
	
	void OnTriggerEnter(Collider other){
//		Debug.Log ("Escorregar");
		if(other.tag == "Player"){
			
			StartCoroutine (Automatic ());
			
			
			
		}
		
		
	}
	public IEnumerator Automatic ()
	{	
		
		FingerJump.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		swipe.Jump ();
		yield return new WaitForSeconds (0.8f);
		FingerJump.SetActive (false);
		//		SwipeMotions p = gameObject.GetComponent<SwipeMotions>();
		//		p.Shrink();
	}
}
