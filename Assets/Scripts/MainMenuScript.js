var newSkin : GUISkin;
var logoTexture : Texture2D;

function theFirstMenu() {
		//layout start
		GUI.BeginGroup(Rect(Screen.width / 2 - 150, 100, 350, 400));
		
		//the menu background box
		GUI.Box(Rect(0, 0, 330, 400), "");
		
		//logo picture
		GUI.Label(Rect(15, 10, 300, 68), logoTexture);
		
		///////main menu buttons
		//game start button
		if(GUI.Button(Rect(80, 100, 180, 80), "START GAME")) {
//		var script: SwipeMotion = GetComponent("SwipeMotion"); 
		//Application.LoadLevel("FASE01");
		var script:MainMenuScript = GetComponent("MainMenuScript"); 
		script.enabled = false;
//		var script2: MapMenuScript  = GetComponent("MapMenuScript"); 
//		script2.enabled = true;
		}
		//quit button
		if(GUI.Button(Rect(80, 200, 180, 80), "QUIT")) {
		Application.Quit();
		}
		
		if(GUI.Button(Rect(80, 300, 180, 80), "CREDIT'S")) {
		Application.Quit();
		}
		
		//layout end
		GUI.EndGroup(); 
}

function OnGUI () {
		//load GUI skin
		GUI.skin = newSkin;
		
		//execute theFirstMenu function
		theFirstMenu();
}