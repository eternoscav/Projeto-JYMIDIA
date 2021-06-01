using UnityEngine;
using System.Collections;

public class BotaoMenu : MonoBehaviour {
	public AudioClip Selecionar;
	public GameObject menu;
	public GameObject selectPlayer;
	public GameObject Opcoes;
//	public AudioClip clique; 
	public string nome;
	
	// Use this for initialization
	void Start () {
		//audio.mute = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	void OnMouseEnter() {

	}
	
	void OnMouseExit() {
		if (nome == "Play" || nome == "Opcoes" || nome == "Quit") {
				}	renderer.enabled =false;
	}	
	
	void OnMouseDown() {
		if (nome == "Play"){
			audio.PlayOneShot (Selecionar);
			renderer.enabled =true;
			StartCoroutine (AcaoPlay ());
			 
		//	audio.mute = false;
			//audio.PlayOneShot(clique);
		//	audio.Play();
//			GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
//			gc.ChangeLevel("FASE01");
		}

		else if (nome == "Opcoes"){
			audio.PlayOneShot (Selecionar);
			renderer.enabled =true;
			StartCoroutine (AcaoOpcoes ());


			//Application.Quit();
		}
		else if (nome == "Score"){
			renderer.enabled =true;
			//Application.Quit();
		}
		else if (nome == "Quit"){
			audio.PlayOneShot (Selecionar);
			renderer.enabled =true;
			Application.Quit();
		}
	}

	IEnumerator AcaoPlay ()
	{
		yield return new WaitForSeconds (0.8f);
		renderer.enabled =false;
		selectPlayer.SetActive (true);
		menu.SetActive (false);
		
	}
	IEnumerator AcaoOpcoes ()
	{
		yield return new WaitForSeconds (0.8f);
		renderer.enabled =false;
		Opcoes.SetActive (true);
		menu.SetActive (false);
		
	}
}
