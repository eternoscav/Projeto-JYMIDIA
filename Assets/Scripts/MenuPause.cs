using UnityEngine;
using System.Collections;

public class MenuPause : MonoBehaviour {
	public AudioClip Selecionar;
	public GameObject PauseMenu;
	public string nome;
	public SwipeMotions player;



	void OnMouseDown() {
		if (nome == "Menu"){
			audio.PlayOneShot (Selecionar);
			renderer.enabled =true;
			player.Pausar = false;
			StartCoroutine (AcaoMenu ());

		}
		else if (nome == "Despause"){
			audio.PlayOneShot (Selecionar);
			renderer.enabled =true;
			player.Pausar = false;
			StartCoroutine (AcaoPause ());

		}

		else if (nome == "Sair"){
			audio.PlayOneShot (Selecionar);
			renderer.enabled =true;
			Application.Quit();
		}

	}

	IEnumerator AcaoMenu ()
	{
		yield return new WaitForSeconds (0.1f);
		//PauseMenu.SetActive (false);
		Application.LoadLevel ("LEVEL01");
		//renderer.enabled =false;

	}

	IEnumerator AcaoPause ()
	{
		yield return new WaitForSeconds (0.1f);
		PauseMenu.SetActive (false);
		renderer.enabled =false;
	}

}
