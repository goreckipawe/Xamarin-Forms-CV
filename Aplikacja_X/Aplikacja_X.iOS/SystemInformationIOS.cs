using Aplikacja_X.iOS;
using Xamarin.Forms;
using Xamarin.Essentials;

[assembly: Dependency(typeof(SystemInformationIOS))]
namespace Aplikacja_X.iOS
{
    public class SystemInformationIOS : SystemInformation
    {
        public string GetAppVersion()
        {
            return VersionTracking.CurrentVersion;
        }
        public string GetOsVersion() {
            return DeviceInfo.VersionString;
        }
    }
}