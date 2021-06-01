using UnityEngine;
using System.Collections;

public class Opcoes : MonoBehaviour {
	public AudioClip Selecionar;
	public AudioClip Selecionado;
	public SwipeMotions ligar;
	public GameObject Botoes;
	public GameObject Menu;
	public GameObject Geral;
	public GameObject Slide;
	public GameObject Jump;
	public GameObject Power;
	public Material MaterialAtual ;
	public Material MaterialFinal ;
	public int valorFace;
	public string nome;
	public bool ligarbotao;


//	void OnMouseEnter() {
//		if (name == "Slide") {
//			audio.PlayOneShot (Selecionar);
//			renderer.enabled =true;
//						renderer.material = MaterialAtual;
//				} else if (name == "Botao") {
//			renderer.enabled =true;
//			renderer.material = MaterialAtual;
//			audio.PlayOneShot (Selecionar);
//				}
//	}
	
//	void OnMouseExit() {
//		renderer.enabled =false;
//	}	
	
	void OnMouseDown() {
		if (nome == "Slide"){
			audio.Play();
			audio.PlayOneShot (Selecionado);
			renderer.material = MaterialFinal;
			StartCoroutine (AcaoSlide ());

			
		}
		 
		else if (nome == "Botao"){
			audio.Play();
			audio.PlayOneShot (Selecionado);
			renderer.material = MaterialFinal;
			StartCoroutine (AcaoBotao ());

		}

	}
	
	public IEnumerator AcaoBotao ()
	{
		yield return new WaitForSeconds (0.8f);
		Geral.SetActive (false);
		renderer.enabled = true;
		ligar.LigarBotao = false;
		ligar.LigarSlide = true; 
		//Botoes.SetActive (false);
		Power.SetActive (false);
		Jump.SetActive (false);
		Slide.SetActive (false);
		Menu.SetActive (true);
	//	renderer.enabled =false;
		renderer.material = MaterialAtual;
		ligarbotao = false;
		
	}
	public IEnumerator AcaoSlide ()
	{
		yield return new WaitForSeconds (0.8f);
		Geral.SetActive (false);
		renderer.enabled =true;
		ligar.LigarSlide = false;
		ligar.LigarBotao = true;
		//Botoes.SetActive (true);
		Power.SetActive (true);
		Jump.SetActive (true);
		Slide.SetActive (true);
		Menu.SetActive (true);
	//	renderer.enabled =false;
		renderer.material = MaterialAtual;
		ligarbotao = true;
		
	}
	public IEnumerator AcaoSlideInicial ()
	{
		yield return new WaitForSeconds (0);
		Geral.SetActive (false);
		ligar.LigarSlide = true;
		ligar.LigarBotao = false;
		Power.SetActive (false);
		Jump.SetActive (false);
		Slide.SetActive (false);
		Menu.SetActive (false);
		yield return new WaitForSeconds (20);
		
		
	}
	

	
}

	