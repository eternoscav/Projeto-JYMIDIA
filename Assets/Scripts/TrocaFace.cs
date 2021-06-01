using UnityEngine;
using System.Collections;

public class TrocaFace : MonoBehaviour {
	public int valorFace;
	public Material RostoNormal;
	public Material RostoAlegre;
	public Material RostoDor;
	public Material RostoMorte;
	Material[] face;


	void Update() {
		if(valorFace == 0){
			face = renderer.materials;
			face[1] = RostoNormal;
			renderer.materials = face;
		}
		if(valorFace == 1){
			face = renderer.materials;
			face[1] = RostoAlegre;
			renderer.materials = face;
		}
		else if (valorFace == 2){
			face = renderer.materials;
			face[1] = RostoDor;
			renderer.materials = face;

		}
		else if (valorFace == 3){
			face = renderer.materials;
			face[1] = RostoMorte;
			renderer.materials = face;
		}

	}

}