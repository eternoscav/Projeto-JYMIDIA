using UnityEngine;
using System.Collections;

public class anime : MonoBehaviour {
     
void Update (){
	//	animation.Blend("Running");
		if (Input.GetButton("superun")) {
			foreach (AnimationState state in animation) {
				state.speed = 2;
			}
		}
		
	}
}