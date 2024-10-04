using BugRepoOnAppearingCall.Pages;

namespace BugRepoOnAppearingCall
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("SelectDevicePage", typeof(SelectDevicePage));
            Routing.RegisterRoute("DeviceSpecificPage", typeof(DeviceSpecificPage));
        }
    }
}
