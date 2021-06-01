using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour
{
	
		public static Inimigo instance;
		public SwipeMotions player;
		public GameObject SumirInimigo;
		public PlataformMoviment plataform;
		public int Vidas = 0;
		public float velocidade;
		public float duration = 0;
		public GameObject PedrasGrandes;
		public GameObject PedrasPequenas;
		public int moveSpeed;
		public int rotationSpeed;
		public Transform target;
		public Transform[] targets;
		public int atualTarget = 0;
		public AudioClip Explosion;
		public AudioClip SomInimigo;
//	public ParticleSystem particulas;
	
		void Awake ()
		{
				instance = this;
		}
	
		public IEnumerator Star ()
		{
		
		
				Vidas -= 1;
				if (Vidas > 0) {
						PedrasPequenas.SetActive (true);
						audio.PlayOneShot (SomInimigo);
						yield return new WaitForSeconds (0.7f);
						PedrasPequenas.SetActive (false);
				}
				
		
				if (Vidas == 0) {
						audio.PlayOneShot (SomInimigo);
						PedrasGrandes.SetActive (true);
						audio.PlayOneShot (Explosion);
						yield return new WaitForSeconds (0);	
						collider.enabled = false;
						SumirInimigo.SetActive (false);
			
				}
		
		
		}
	
		public void AumentarVidas (int vida)
		{ 
				Vidas += vida;
		
		
		}

		void OnTriggerEnter (Collider other)
		{
		
				if (other.tag == "Player") {
						SwipeMotions p = other.gameObject.GetComponent<SwipeMotions> ();
						p.Morte ();
						plataform.Speed = 0;
			
			
				}
		
		}
	
		public void AplicarDano ()
		{
		
				StartCoroutine (Star ());
		}
	
}



