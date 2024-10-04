namespace BugRepoOnAppearingCall.Pages;

public partial class SelectDevicePage : ContentPage
{
	public SelectDevicePage()
	{
		InitializeComponent();
	}

    private void SelectDevicePage_OnAppearing(object? sender, EventArgs e)
    {
        DisplayAlert("SelectDevicePage", "... appeared", "Ok");
    }

    private async void OnNavigateClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//DeviceSpecificPage", true);
    }
}