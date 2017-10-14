namespace EmptyApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new EmptyApp.App());
        }
    }
}