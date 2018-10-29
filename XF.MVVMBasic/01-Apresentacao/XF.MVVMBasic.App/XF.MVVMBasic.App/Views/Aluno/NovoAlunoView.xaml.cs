using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.MVVMBasic.App.Views.Aluno
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NovoAlunoView : ContentPage
	{
		public NovoAlunoView ()
		{
			InitializeComponent ();
		}

        private void Save_Clicked(object sender, EventArgs e)
        {

        }
    }
}