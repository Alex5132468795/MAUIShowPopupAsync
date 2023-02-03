using CommunityToolkit.Maui.Views;
using CommunityToolkit;
namespace MauiApp14;

public partial class MainPage : ContentPage
{
	bool s = false;
	bool x = false;
	bool a = false;
	public MainPage()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        this.ShowPopup(new NewPage1());
        while (s == false || x == false || a == false)
        {
        this.ShowPopup(new NewPage1());
        Object q = await this.ShowPopupAsync(new NewPage1());
		VerticalStackLayout w = new VerticalStackLayout();
		Label f = new Label();
		f.Text = ((q as ImageButton).StyleId);
		w.Add(f);
		switch ((q as ImageButton).StyleId)
		{
			case "A":
				s = true;
				break;
			case "B":
				x = true;
				break;
			case "C":
				a = true;
				break;
        }
        cont.Add(w);
       
		
            
        }
    }
}

