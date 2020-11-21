using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja_X
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail_CV_PageMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetail_CV_PageMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetail_CV_PageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetail_CV_PageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetail_CV_PageMenuItem> MenuItems { get; set; }
            
            public MasterDetail_CV_PageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetail_CV_PageMenuItem>(new[]
                {
                    new MasterDetail_CV_PageMenuItem { Id = 0, Title = "CV", Page = new MasterDetail_CV_PageDetail(), TargetType = typeof(MasterDetail_CV_PageDetail)},
                    new MasterDetail_CV_PageMenuItem { Id = 1, Title = "Skills", Page = new Skills("Skills"), TargetType = typeof(Skills) },
                    new MasterDetail_CV_PageMenuItem { Id = 2, Title = "Education", Page = new Education("Education"), TargetType = typeof(Education) },
                    new MasterDetail_CV_PageMenuItem { Id = 3, Title = "Experience", Page = new Experience("Experience"), TargetType = typeof(Experience) },
                    new MasterDetail_CV_PageMenuItem { Id = 4, Title = "Hobbies", Page = new Hobbies("Hobbies"), TargetType = typeof(Hobbies) },
                    new MasterDetail_CV_PageMenuItem { Id = 5, Title = "Close" }
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}