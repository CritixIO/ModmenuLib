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
  <li>GameName = "gta_sa"; //exe name (without writing .exe)</li>
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
    First : Add a Page
    <li>Page.Add(new Menu.page()); //Add a new Page</li>
    If you want adding a Title on your page (not necessary to use one if you don't want)
    <li>Page[0].Title = "Main Menu"; //Title Text</li>
    <li>Page[0].TitleColor = Color.Cyan; //Title Color</li>
    <li>Page[0].TitleFont = new Font("Arial", 14f, FontStyle.Bold); //Title Font</li>       
    Second : Add your Page Items</br>
    Font Font, string Text, int FunctionType, string[] FunctionType2Values, int ReturnToPage, Action Function
    <li>Exemples :</li>
    <ul>
      <li>Page[0].Add(new Font("Arial", 12f, FontStyle.Bold),"Teleport Menu",0,null,1,null);</li>
      <li>Page[0].Add(new Font("Arial", 12f, FontStyle.Bold),"Godmode",1,null,-1,() => gta.Godmode());</li>
      <li>Page[0].Add(new Font("Arial", 12f, FontStyle.Bold),"SpeedHack",2,new string[] { "1", "2", "3" },-1,() => gta.SpeedHack()</li>
    </ul>
    <li>FuntionType</li>
    <ul>
      <li>0 = Activated Function</li>
      <li>1 = Enable-Disable Function //On Off</li>
      <li>2 = Selected Value Function</li>
    </ul>
    <li>FunctionType2Value</li>
    <ul>
      <li>null = if FunctionType wasn't set to 2</li>
      <li>new string[]{ "val1","val2","val3".... }</li>
    </ul>
    <li>ReturnToPage</li>
    <ul>
      <li>-1 = if you don't wan't to go on a Page index</li>
    </ul>
    <li>Function</li>
    <ul>
      <li>null = if you don't wan't having a void Function</li>
      <li>() => void(*params*) = if you wan't having a void Function</li>
    </ul>
  </ul>
</ul>

<h3>Script for your void FunctionType 1</h3>
<h2>
  int OnItem = Page[ModmenuLib.Menu.Get.WasOnPage].Items.FindIndex(x => x.WasOn == true);
  if(Page[ModmenuLib.Menu.Get.WasOnPage].Items[OnItem].FunctionActivated == true)
  {
    //On
  }
  else
  {
    //Off
  }
</h2>  
<h3>Script for your void FunctionType 2</h3>
<h2>
int OnItem = Page[ModmenuLib.Menu.Get.WasOnPage].Items.FindIndex(x => x.WasOn == true);
if(Page[ModmenuLib.Menu.Get.WasOnPage].Items[OnItem].Function2_SelectedValue == "val1")
{
  //code
}
else if(Page[ModmenuLib.Menu.Get.WasOnPage].Items[OnItem].Function2_SelectedValue == "val2")
{
  //code
}......
</h2>
</head>
</html>
