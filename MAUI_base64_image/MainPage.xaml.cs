namespace MAUI_base64_image
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new viewModels.ImagesViewModels();
        }
    }
}
