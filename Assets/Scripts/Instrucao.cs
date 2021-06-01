using UnityEngine;
using System.Collections;

public class Instrucao : MonoBehaviour {
		//no audio
		public float FPS;
		public Texture frame1;
		public Texture frame2;
		
		void Start() {
			//if (Frames.Length == 0)
			//	return;
			
			//float index = Time.time * FPS;
			//index = index % Frames.Length;

		StartCoroutine (Super ());

		}
	public IEnumerator Super (){

		renderer.material.mainTexture = frame1;
		yield return new WaitForSeconds (0.5f);
		renderer.material.mainTexture = frame2;//[(int)index];
	}


}
