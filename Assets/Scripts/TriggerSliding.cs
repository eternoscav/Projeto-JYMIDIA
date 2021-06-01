

using UnityEngine;
using System.Collections;

public class TriggerSliding : MonoBehaviour {
				 
	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
			p.Shrink ();
			p.testeShrink = true;
		//	Slide.SlideLiga = true;
		//	Debug.Log("ESTA ESCORREGANDO");
//		} else{
//			Slide.SlideLiga = false;
//			Debug.Log("NAO ESTA ESCORREGANDO");
	}   
	}
	
	void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
			SwipeMotions p = other.gameObject.GetComponent<SwipeMotions>();
			p.SlideLiga = true;
			p.testeShrink = false;
			p.ligarRunning = true;

				//			Debug.Log("NAO ESTA ESCORREGANDO");
		}    
	}
	}