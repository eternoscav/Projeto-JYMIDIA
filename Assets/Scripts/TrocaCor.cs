using UnityEngine;
using System.Collections;
	
public class TrocaCor : MonoBehaviour
{
		public Material CuboNormal ;
		public Material CuboRed ;
		public Material CuboSelecionado;
		public GameObject player;
		public bool Ligado;
		public bool PlayerGirl;
		public bool PlayerBoy;
		public bool PlayerSpecial;
		
		void Update ()
		{
				if (Ligado == true) {
						player.renderer.material = CuboRed;
						if (PlayerGirl == true) {
								player.renderer.material = CuboSelecionado;
								StartCoroutine (IniciarFase ());
						}
						if (PlayerSpecial == true) {
								player.renderer.material = CuboSelecionado;
								//StartCoroutine (IniciarFase ());
						}
						if (PlayerBoy == true) {
								player.renderer.material = CuboSelecionado;
								StartCoroutine (IniciarFase ());
						}
				} else {
						player.renderer.material = CuboNormal;
				}
			
		}
		
		public IEnumerator IniciarFase ()
		{
				yield return new WaitForSeconds (2);
				Application.LoadLevel ("LEVEL01");
			
		}
}

