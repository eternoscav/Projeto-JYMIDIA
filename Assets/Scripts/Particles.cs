using UnityEngine;
using System.Collections;

public class Particles : MonoBehaviour {
	public ParticleSystem hSliderValue;
	void Update() {
		hSliderValue.maxParticles = 100;
	}
//	void OnGUI() {
//		hSliderValue = GUI.HorizontalSlider(new Rect(25, 25, 100, 30), hSliderValue, 0, 100F);
//	}
}