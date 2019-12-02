<html>
<head>
<h1>ModmenuLib allow you to create your own Menu fast and easy on overlay over
fullscreen and windowed executables(.exe)</h1>
  
First Step you need to declare it where you wan't in your project : <h4>new ModmenuLib.Overlay();</h4> <br/>
Second Step you need to modify contents inside the void "Load()" in <h4>ModmenuLib.Menu.Load.cs</h4> <br/>

<h3>STEP's for create your Menu : <br/>
Note, all settings are auto updated in the Draw events if your change directly in your Menu</h3>
<ul>
  <li><h4>Step 1 : Settings</h4></li>
  <ul>
  <h4>exe name (without writing .exe)</h4>
  <li>GameName = "gta_sa"; </li>
  <h4>Image Background (use my lib https://github.com/AmlostudioDev/ZipLib if you wan't)</h4>
  <li>Image = null;</li>
  <h4>Menu transparency value's 0-100 only</h4>
  <li>Opacity = 100;</li>
  <h4>Location of your Menu</h4>
  <li>Location = new Point(10,10); </li>
  <h4>Size of your Menu (if Image != null, the Size was set to the image Size)</h4>
  <li>Size = new Size(200, 400); </li>
  <h4>Key for Open and Close the Menu</h4>
  <li>Key.OpenClose = Keys.Insert; </li>
  <h4>Key for Select Item -1</h4>
  <li>Key.Up = Keys.Up; </li>
  <h4>Key for Select Item +1</h4>
  <li>Key.Down = Keys.Down; </li>
  <h4>Key for Select Value -1 + Auto Active Item Function</h4>
  <li>Key.Left = Keys.Left; </li>
  <h4>Key for Select Value +1 + Auto Active Item Function</h4>
  <li>Key.Right = Keys.Right; </li>
  <h4>Key for Enable-Disable a Item Function</h4>
  <li>Key.Action = Keys.Enter; </li>
  <h4>Color of your Menu</h4>
  <li>Color = Color.Black; </li>
  <h4>Default Item Color</h4>
  <li>Default_LineColor = Color.White; </li>
  <h4>Selected Item Color</h4>
  <li>Selected_LineColor = Color.Fuchsia; </li>
  <h4>Enable Color Function</h4>
  <li>Function_Enable_Color = Color.Green; </li> 
  <h4>Disable Color Function</h4>
  <li>Function_Disable_Color = Color.Red;</li> 
  <h4>Selected Value Color</h4>
  <li>Function2_Selected_Color = Color.Orange; </li> 
  <h4>Text of the Enable Function</h4>
  <li>Enable = "On"; </li> 
  <h4>Text of the Disable Function</h4>
  <li>Disable = "Off"; </li> 
  <h4>Chars before and after the Enable-Disable-Value Text</h4>
  <li>Bars = new string[] { "[", "]" }; </li> 
  <h4>Color of the Chars</h4>
  <li>Bars_Color = Color.White; </li>
  </ul>
  <li><h4>Step 2 : Creating your Menu</h4></li>
  <ul>
    <h3>First : Add a Page</h3>
    <li>Page.Add(new Menu.page()); //Add a new Page</li>
    If you want adding a Title on your page (not necessary to use one if you don't want)
    <li>Page[0].Title = "Main Menu"; //Title Text</li>
    <li>Page[0].TitleColor = Color.Cyan; //Title Color</li>
    <li>Page[0].TitleFont = new Font("Arial", 14f, FontStyle.Bold); //Title Font</li>       
    <h3>Second : Add your Page Items</br></h3>
    Font Font, string Text, int FunctionType, string[] FunctionType2Values, int ReturnToPage, Action Function
    <li><h4>Exemples<h4></li>
    <ul>
      <li>Page[0].Add(new Font("Arial", 12f, FontStyle.Bold),"Teleport Menu",0,null,1,null);</li>
      <li>Page[0].Add(new Font("Arial", 12f, FontStyle.Bold),"Godmode",1,null,-1,() => gta.Godmode());</li>
      <li>Page[0].Add(new Font("Arial", 12f, FontStyle.Bold),"SpeedHack",2,new string[] { "1", "2", "3" },-1,() => gta.SpeedHack()</li>
    </ul>
    <li><h4>FuntionType</h4></li>
    <ul>
      <li>0 = Activated Function</li>
      <li>1 = Enable-Disable Function //On Off</li>
      <li>2 = Selected Value Function</li>
    </ul>
    <li><h4>FunctionType2Value</h4></li>
    <ul>
      <li>null = if FunctionType wasn't set to 2</li>
      <li>new string[]{ "val1","val2","val3".... }</li>
    </ul>
    <li><h4>ReturnToPage</h4></li>
    <ul>
      <li>-1 = if you don't wan't to go on a Page index</li>
    </ul>
    <li><h4>Function</h4></li>
    <ul>
      <li>null = if you don't wan't having a void Function</li>
      <li>() => void(*params*) = if you wan't having a void Function</li>
    </ul>
  </ul>
</ul>

<h3>Script for your void FunctionType 1</h3>
<h4>
  int OnItem = Page[ModmenuLib.Menu.Get.WasOnPage].Items.FindIndex(x => x.WasOn == true);</br>
  if(Page[ModmenuLib.Menu.Get.WasOnPage].Items[OnItem].FunctionActivated == true)</br>
  {</br>
    //On</br>
  }</br>
  else</br>
  {</br>
    //Off</br>
  }</br>
</h4>  
<h3>Script for your void FunctionType 2</h3>
<h4>
int OnItem = Page[ModmenuLib.Menu.Get.WasOnPage].Items.FindIndex(x => x.WasOn == true);</br>
if(Page[ModmenuLib.Menu.Get.WasOnPage].Items[OnItem].Function2_SelectedValue == "val1")</br>
{</br>
  //code</br>
}</br>
else if(Page[ModmenuLib.Menu.Get.WasOnPage].Items[OnItem].Function2_SelectedValue == "val2")</br>
{</br>
  //code</br>
}......
</h4>
</head>
</html>
