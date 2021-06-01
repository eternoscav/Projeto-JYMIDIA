
    function Start () {
       yield Fade(0, 0.6, 1);  // Start, end, length in seconds
       yield WaitForSeconds(9); // Or whatever
       yield Fade(0.6, 0, 1);  // Start, end, length in seconds  
    }



function Fade (start : float, end : float, length : float) {
for (var i = 0.0; i < 1.0; i += Time.deltaTime*(1/length)) {
renderer.material.color.a = Mathf.Lerp(start, end, i);
yield;
}
} 