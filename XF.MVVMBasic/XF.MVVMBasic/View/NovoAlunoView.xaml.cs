using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.MVVMBasic.ViewModel;

namespace XF.MVVMBasic.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NovoAlunoView : ContentPage
	{
        AlunoViewModel vmAluno;

		public NovoAlunoView ()
		{
            vmAluno = new AlunoViewModel();
            BindingContext = vmAluno;

			InitializeComponent ();
		}

        private void SalvarNovoAluno(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(vmAluno.RM) || string.IsNullOrWhiteSpace(vmAluno.Nome) || string.IsNullOrWhiteSpace(vmAluno.Email))
            {
                DisplayAlert("Cadastro inválido!", "Preencha todos os campos.", "OK");
            }
            else
            {
                AlunoViewModel.AddAluno(vmAluno);
                Navigation.PopModalAsync();
            }
        }
    }
}