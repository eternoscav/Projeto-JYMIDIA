using UnityEngine;
using System.Collections;

public class TrocaRoupa : MonoBehaviour
{

		public GameObject player;
		public GameObject CharCat;
		public GameObject Char;
		public GameObject Effect;
		public SwipeMotions swipe;
		//public bool Magia1;
		//public bool Magia2;

	
		void Update ()
		{
				swipe.Magia1 = false;
				//if(Magia1 == true)
				//	player.renderer.material = faceAtual;
				CharCat.SetActive (true);
				Char.SetActive (false);
				Effect.SetActive (true);

		

		}

}