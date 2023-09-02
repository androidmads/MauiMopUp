using Mopups.Pages;
using Mopups.Services;

namespace MauiMopUp;

public partial class MyPopupPage : PopupPage
{
	public MyPopupPage()
	{
		InitializeComponent();
	}

    private void LoginButton_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}