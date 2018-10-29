using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.MVVMBasic.App.ViewModels;

namespace XF.MVVMBasic.App.Views.Aluno
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlunosListView : ContentPage
	{

        AlunoViewModel alunoViewModel = new AlunoViewModel();

        public AlunosListView ()
		{
			InitializeComponent ();

            lvAlunos.ItemsSource = await alunoViewModel.GetAluno();

        }
	}
}