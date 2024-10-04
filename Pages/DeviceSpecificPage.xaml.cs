namespace BugRepoOnAppearingCall.Pages;

public partial class DeviceSpecificPage : ContentPage
{
	public DeviceSpecificPage()
	{
		InitializeComponent();
	}

    private async void OnNavigateClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage", true);
    }
}