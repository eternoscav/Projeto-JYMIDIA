using UnityEngine;
using System.Collections;

public class PlataformMoviment : MonoBehaviour {
	public float Speed = 0;
	void Update() {
		transform.Translate(Vector3.left * Time.deltaTime * Speed );
		//transform.Translate(Vector3.up * Time.deltaTime, Space.World);
	}
}