using Aplikacja_X.UWP;
using Xamarin.Forms;
using Xamarin.Essentials;

[assembly: Dependency(typeof(SystemInformationWindows))]
namespace Aplikacja_X.UWP
{
    public class SystemInformationWindows : SystemInformation
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