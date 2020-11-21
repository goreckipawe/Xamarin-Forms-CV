using Aplikacja_X.Droid;
using Xamarin.Forms;
using Xamarin.Essentials;


[assembly: Dependency(typeof(SystemInformationAndroid))]
namespace Aplikacja_X.Droid
{
    public class SystemInformationAndroid : SystemInformation
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