import "github.com/fatih/color"

<html>
<head>
<h1>ModmenuLib allow you to create your own Menu fast and easy on overlay over<br/>
fullscreen and windowed executables(.exe)</h1>
First Step you need to declare it where you wan't in your project : "new ModmenuLib.Overlay();" <br/>
Second Step you need to modify contents inside the void "Load()" in ModmenuLib.Menu.Load.cs <br/>

<h3>STEP's for create your Menu : <br/>
Note, all settings are auto updated in the Draw events if your change directly in your Menu</h3>
<ul>
  <li><h4>Step 1 : Settings</h4></li>
  <ul>
  <li>GameName = "gta_sa"; color.Green("//exe name (without writing .exe)")</li>
  <li>Image = null; //Image Background (use my lib https://github.com/AmlostudioDev/Zip if you wan't)</li>
  <li>Opacity = 100; //Menu transparency value's 0-100 only</li>
  <li>Location = new Point(10,10); //Location of your Menu</li>
  <li>Size = new Size(200, 400); //Size of your Menu (if Image != null, the Size was set to the image Size)</li>
  <li>Key.OpenClose = Keys.Insert; //Key for Open and Close the Menu</li>
  <li>Key.Up = Keys.Up; //Key for Select Item -1</li>
  <li>Key.Down = Keys.Down; //Key for Select Item +1</li>
  <li>Key.Left = Keys.Left; //Key for Select Value -1 + Auto Active Item Function</li>
  <li>Key.Right = Keys.Right; //Key for Select Value +1 + Auto Active Item Function</li>
  <li>Key.Action = Keys.Enter; //Key for Enable-Disable a Item Function</li>
  <li>Color = Color.Black; //Color of your Menu</li>
  <li>Default_LineColor = Color.White; //Default Item Color</li>
  <li>Selected_LineColor = Color.Fuchsia; //Selected Item Color</li>
  <li>Function_Enable_Color = Color.Green; //Enable Color Function</li> 
  <li>Function_Disable_Color = Color.Red; //Disable Color Function</li> 
  <li>Function2_Selected_Color = Color.Orange; //Selected Value Color</li> 
  <li>Enable = "On"; //Text of the Enable Function</li> 
  <li>Disable = "Off"; //Text of the Disable Function</li> 
  <li>Bars = new string[] { "[", "]" }; //Chars before and after the Enable-Disable-Value Text</li> 
  <li>Bars_Color = Color.White; //Color of the Chars</li>
  </ul>
  <li><h4>Step 2 : Creating your Menu</h4></li>
  <ul>
  </ul>
</ul>
</head>
</html>
