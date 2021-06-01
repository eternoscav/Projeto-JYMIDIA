using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public int FrutasGerais;
	public int Vidas;
	public GUIText GuiVidas;
	public GUIText GuiFrutas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			Vidas = gamestate.Instance.vidas;
			GuiVidas.text = Vidas.ToString ();
			FrutasGerais = gamestate.Instance.frutas;
			GuiFrutas.text = FrutasGerais.ToString ();
		if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel("LEVEL02");
				}
	}
}
