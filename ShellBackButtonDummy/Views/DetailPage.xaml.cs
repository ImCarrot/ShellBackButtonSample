using ShellBackButtonDummy.ViewModels;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls;

namespace ShellBackButtonDummy.Views
{
    public sealed partial class DetailPage : Page
    {
        public DetailPage()
        {
            InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Disabled;
        }

        private void MyDummyControl_PrimaryButtonClicked()
        {
            if (ViewModel.NavigationService.CanGoBack)
                ViewModel.NavigationService.GoBack();
        }
    }
}
