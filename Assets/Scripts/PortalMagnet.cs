using UnityEngine;
using System.Collections;

public class PortalMagnet : MonoBehaviour {
//	public BulletRed bulletred;
//	public GameObject spawnMaca;
	public GameObject target;
	
	void Update() {
		if(target) {
	//		Instantiate (bulletred.gameObject, spawnMaca.transform.position, Quaternion.identity);
			//transform.position = Vector3.MoveTowards(spawnMaca.position, target.transform.position, 1.0f);
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 1.0f);
		}
	}
	
//	void OnTriggerEnter(Collider other) {
//		if(other.gameObject.tag == "Magnet") {
//			target = other.gameObject;
//		}
//	}
}
