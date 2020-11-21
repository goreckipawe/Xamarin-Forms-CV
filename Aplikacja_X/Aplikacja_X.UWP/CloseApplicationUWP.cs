using Aplikacja_X.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(CloseApplicationUWP))]
namespace Aplikacja_X.UWP
{
    class CloseApplicationUWP : CloseApplication
    {
        public void closeApplication()
        {
            Windows.UI.Xaml.Application.Current.Exit();
        }
    }
}
