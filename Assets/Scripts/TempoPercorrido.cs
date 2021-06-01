using UnityEngine;
using System.Collections; 

public class TempoPercorrido : MonoBehaviour {
	public GUIText gText; // drag here the GUIText from Hierarchy view

	public float timer =0;
	public bool Zerar;
	public float maxTime;

		
	void Start(){

		maxTime = timer;

	}
	
	void Update(){
		if(Zerar == true){
		timer = 0;
		}
		StartCoroutine (Tempo ());

	}
	public IEnumerator Tempo ()
	{
		yield return new WaitForSeconds (0);
		timer += Time.deltaTime *12;
		//	timer = Mathf.Clamp(timer, 0, maxTime);
		
		float t = Mathf.Abs(timer); // get the absolute timer value
		int seconds = (int)t ;//% 60; // calculate the seconds
		// int minutes = (int)t / 60; // calculate the minutes
		string minSec =  "" + seconds + "m"; // create the formatted string
		
		gText.text = minSec; // update the GUIText

	}

	
}
