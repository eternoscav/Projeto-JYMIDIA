using UnityEngine;
using System.Collections;

public class MenuPrincipal : MonoBehaviour {
	public SwipeMotions swipe;
	public GameObject selectPlayer;

	
	
	void  OnGUI (){
		
		GUILayout.BeginArea( new Rect(Screen.width/2-225,0,450,Screen.height));
		
		GUILayout.FlexibleSpace();	
		
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();	
		//GUILayout.Label("Select a scene");
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
		GUILayout.Space(10);
		
		GUILayout.BeginHorizontal();
		
		
		GUILayout.BeginVertical();
		if(GUILayout.Button("INICIAR GAME")){
			selectPlayer.SetActive (true);
			swipe.menu.enabled = false;
			//swipe.LigarGame = true;
			//	Application.LoadLevel(1);
		}
		
			
		if(GUILayout.Button("SCORE")){
			//Application.LoadLevel(2);
		}
		if(GUILayout.Button("SAIR")){
			Application.Quit();
		//	Application.LoadLevel(3);
		}

		GUILayout.EndVertical();
		
		GUILayout.Space(30);
		

		
		
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
		
	}
}