using UnityEngine;
using System.Collections;

public class AnimarPortal : MonoBehaviour {
	
	
	void Start (){
		GetComponent<Animation>().enabled = true;
		animation.Play();
	}
	
}