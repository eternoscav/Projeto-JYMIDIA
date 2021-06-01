using UnityEngine;
using System.Collections;

public class Rotation2 : MonoBehaviour {
	//	public int speed = 100;
	void Update() {
		transform.Rotate(Vector3.up * Time.deltaTime* 200);
		//						foreach (AnimationState state in animation) {
		//		state.speed = 0.5f;
		//	}
	}
}
