using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.MVVMBasic.App.Services;
using XF.MVVMBasic.App.Views;
using XF.MVVMBasic.App.Views.Aluno;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XF.MVVMBasic.App
{
    public partial class App : Application
    {
        

        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new MenuPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
