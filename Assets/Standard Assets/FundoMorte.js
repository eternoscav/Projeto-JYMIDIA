#pragma strict

public class FundoMorte extends MonoBehaviour  
{
public var Ligar : boolean = false;

public function Teste(){

      yield Fade(0, 1, 0.5);  // Start, end, length in seconds
 //      }
      yield WaitForSeconds(3); // Or whatever
       yield Fade(1, 0, 0.5);
       Ligar = true;

}


    public function Update () {
        if(Ligar == true){
        Ligar = false;
        Teste();
    		
		
		}
    }

		public function Fade (start : float, end : float, length : float) {
			for (var i = 0.0; i < 1.0; i += Time.deltaTime*(1/length)) {
			renderer.material.color.a = Mathf.Lerp(start, end, i);
			yield;

			}
		} 
}