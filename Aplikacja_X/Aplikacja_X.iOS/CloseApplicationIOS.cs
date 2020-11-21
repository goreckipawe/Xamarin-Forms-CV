using System.Threading;
using Aplikacja_X.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(CloseApplicationIOS))]
namespace Aplikacja_X.iOS
{
    class CloseApplicationIOS : CloseApplication
    {
        public void closeApplication()
        {
            Thread.CurrentThread.Abort();
        }
    }
}