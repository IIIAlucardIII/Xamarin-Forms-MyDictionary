using Xamarin.Forms;

namespace MyDictionary
{    
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage(new WordList());
            navigationPage.BarBackgroundColor = Color.FromRgb(55, 66, 60);
            navigationPage.BarTextColor = Color.White;

            Detail = navigationPage;

            IsPresented = true;
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            var navigationPage = new NavigationPage(new WordList());
            navigationPage.BarBackgroundColor = Color.FromRgb(55, 66, 60);
            navigationPage.BarTextColor = Color.White;

            Detail = navigationPage;

            IsPresented = false;
        }
    }
}
