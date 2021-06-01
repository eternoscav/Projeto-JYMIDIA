using UnityEngine;
using System.Collections;

public class BulletRed : MonoBehaviour {
	
	public float velocidade;
	public float dano;
	private float lifeTime = 1;
	private SwipeMotions player;
	private Vector3 direcaoBala;

	// Use this for initialization
	void Start () {
		GameObject go =  GameObject.FindWithTag("Player");
		player = go.GetComponent<SwipeMotions>();
		//SwipeMotions p = gameObject.GetComponent<SwipeMotions>();
		if(player.Apples < 50){
		player.RecolherMaca(-1); 
		}
		direcaoBala = player.spawnBullet.transform.right;
		this.transform.Rotate(300, 0, 0);
		Destroy(gameObject, lifeTime);

		
	}

	
	// Update is called once per frame
	void Update () {
		transform.Translate(direcaoBala * velocidade * Time.deltaTime, Space.Self);
		
		
	}
	
	void OnTriggerEnter(Collider other){

		if(other.tag == "Inimigo"){
		//	Debug.Log ("Relou Inimigo");
			other.GetComponent<Inimigo>().AplicarDano();
			GameObject.Destroy(this.gameObject);
		}

	}	
}
