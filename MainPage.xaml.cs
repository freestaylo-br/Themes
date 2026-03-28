namespace Themes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void SetTheme(AppTheme theme)
        {
            Application.Current.UserAppTheme = theme;

            Preferences.Set("theme", theme.ToString());
        }
        
        void OnLightClicked(object sender, EventArgs e)
        {
            SetTheme(AppTheme.Light);
        }

        void OnDarkClicked(object sender, EventArgs e)
        {
            SetTheme(AppTheme.Dark);
        }

        void OnSystemClicked(object sender, EventArgs e)
        {
            SetTheme(AppTheme.Unspecified);
        }
    }
}