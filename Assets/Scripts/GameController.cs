using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
//	public GUITexture loadingScreen;
	public bool isPaused= false;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
		Application.LoadLevel("LEVEL01");
		DontDestroyOnLoad(gamestate.Instance);
		gamestate.Instance.startState();	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	
	public void ChangeLevel(string newLevel){
	//	loadingScreen.gameObject.SetActive(true);
		Application.LoadLevel(newLevel);
	}
	
	//quando a fase foi carregado
	IEnumerator OnLevelWasLoaded(int level) {
		yield return new WaitForSeconds(0);
	//	loadingScreen.gameObject.SetActive(false);
	}

	}
