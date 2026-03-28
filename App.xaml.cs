namespace Themes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            LoadTheme();

            MainPage = new AppShell();
        }

        void LoadTheme()
        {
            string savedTheme = Preferences.Get("theme", "Unspecified");

            AppTheme theme = savedTheme switch
            {
                "Light" => AppTheme.Light,
                "Dark" => AppTheme.Dark,
                "Unspecified" => AppTheme.Unspecified,
            };

            Application.Current.UserAppTheme = theme;
        }
    }
}