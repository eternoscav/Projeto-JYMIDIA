
using UnityEngine;
using System.Collections;

public class Example2 : MonoBehaviour {
	//SCALE NATIVE RESOLUTION VARIABLES
	public float native_width= 1600;
	public float native_height= 900;
	
	void OnGUI(){
		float rx = Screen.width / native_width;
		float ry = Screen.height / native_height;
		GUI.matrix = Matrix4x4.TRS (new Vector3(0, 0, 0), Quaternion.identity, new Vector3 (rx, ry, 1));
		
		
		
	}
}