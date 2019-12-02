# ModmenuLib
ModmenuLib allow you to create your own Menu fast and easy on overlay over fullscreen and windowed executables(.exe) <br/>
First Step you need to declare it where you wan't in your project : "new ModmenuLib.Overlay();" <br/>
Second Step you need to modify contents inside the void "Load()" in ModmenuLib.Menu.Load.cs <br/>

STEP's for create your Menu : <br/>
1 : Note, all settings are auto updated in the Draw events if your change directly in your Menu<br/>
GameName = ""; //exe name (without writing .exe)<br/>
Image = null; <span style="color:green">//if you wan't an image for your menu (use my lib https://github.com/AmlostudioDev/Zip if you wan't)</span><br/>
Opacity = 100; //Menu transparency value's 0-100 only<br/>
Location = new Point(10,10); //Location of your Menu<br/>
Size = new Size(200, 400); //Size of your Menu (if Image != null, the Size was set to the image Size)<br/>
Key.OpenClose = Keys.Insert; //Key for Open and Close the Menu<br/>
Key.Up = Keys.Up; //Key for Select Item -1<br/>
Key.Down = Keys.Down; //Key for Select Item +1<br/>
Key.Left = Keys.Left; //Key for Select Value -1 + Auto Active Item Function<br/>
Key.Right = Keys.Right; //Key for Select Value +1 + Auto Active Item Function<br/>
Key.Action = Keys.Enter; //Key for Enable-Disable a Item Function<br/>
Color = Color.Black; //Color of your Menu<br/>
Default_LineColor = Color.White; //Default Item Color<br/>
Selected_LineColor = Color.Fuchsia; //Selected Item Color<br/>
Function_Enable_Color = Color.Green; //Enable Color Function<br/>
Function_Disable_Color = Color.Red; //Disable Color Function<br/>
Function2_Selected_Color = Color.Orange; //Selected Value Color<br/>
Enable = "On"; //Text of the Enable Function<br/>
Disable = "Off"; //Text of the Disable Function<br/>
Bars = new string[] { "[", "]" }; //Chars before and after the Enable-Disable-Value Text<br/>
Bars_Color = Color.White; //Color of the Chars<br/>
