var GuiTexture : Texture2D;
 
function OnGUI()
{
    GUI.DrawTexture(ResizeGUI(Rect(100, 100, 100, 100)), GuiTexture);
}    
 
function ResizeGUI(_rect : Rect) : Rect
{
    var FilScreenWidth = _rect.width / 800;
    var rectWidth = FilScreenWidth * Screen.width;
    var FilScreenHeight = _rect.height / 600;
    var rectHeight = FilScreenHeight * Screen.height;
    var rectX = (_rect.x / 800) * Screen.width;
    var rectY = (_rect.y / 600) * Screen.height;
 
    return Rect(rectX,rectY,rectWidth,rectHeight);
}