using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zero
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            TabbedPage cp = new TabbedPage();
            //CarouselPage cp = new CarouselPage();
            cp.Children.Add(new Page1());
            cp.Children.Add(new Page2());
            cp.Children.Add(new Page3());
            MainPage = cp;

            //mudando a cor da barra de titulos
            //Background color
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Black);

            //Title color
            MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
