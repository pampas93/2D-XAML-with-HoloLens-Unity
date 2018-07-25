using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SubscriptionSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ContentPage : Page
    {
        public ContentPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var contentPage = Adept.AppViewManager.Views["MainPage"];
            await contentPage?.SwitchAsync();
        }
    }

    

}
