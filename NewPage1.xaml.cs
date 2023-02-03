namespace MauiApp14;
using CommunityToolkit.Maui.Views;

public partial class NewPage1 : Popup
{
	public NewPage1()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        Close();
    }

    private void A_Clicked(object sender, EventArgs e)
    {
        Close(sender);
    }
}