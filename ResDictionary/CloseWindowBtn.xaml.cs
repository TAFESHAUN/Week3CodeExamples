namespace ResDictionary;

public partial class CloseWindowBtn : ContentView
{

	public string alertMsg; //YOU CLOSE X PAGE
	public string alertPromptMsg; //ARE YOU SURE YOU WANT TO CLOSE
	public int somePageORItemID; // THE ID FOR THE PAGE or CURRENT content being 
	//served to this custom button
	public CloseWindowBtn()
	{
		InitializeComponent();
	}
}