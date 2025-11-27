using Microsoft.Extensions.DependencyInjection;

namespace AgendamentoHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

             MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Height = 700;
            window.Width = 400;

            return window;
        }
    }
}