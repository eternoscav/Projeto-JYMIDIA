using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {
	public int parar = 0;
	public bool desligar = false;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		if (parar <= 50) {
			parar ++;
						guiText.fontSize++;
						desligar = true;	
				}

		if(Input.GetMouseButtonDown(0)){
//			animation.Stop();
//			animation.Blend("cont");
			 StartCoroutine(Reset());

			
		}else{
//			animation.wrapMode = WrapMode.Loop;
//			//animation["idle"].time = 0.0F;
//				animation.Blend("idle");
			
	}
}
	
	public IEnumerator Reset(){
		
		yield return new WaitForSeconds(0);
		Application.LoadLevel("LEVEL01");
//		gameObject.SetActive(true);
		
		
	}
}