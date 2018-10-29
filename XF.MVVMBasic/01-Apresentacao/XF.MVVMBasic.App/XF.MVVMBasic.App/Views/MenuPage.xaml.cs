using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.MVVMBasic.App.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

        private void btnAlunos_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new Views.Aluno.AlunoView());
        }
    }
}