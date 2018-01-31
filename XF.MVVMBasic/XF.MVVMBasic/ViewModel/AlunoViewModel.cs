using System;
using System.Collections.ObjectModel;
using System.Text;
using XF.MVVMBasic.Model;

namespace XF.MVVMBasic.ViewModel
{
    class AlunoViewModel
    {
        #region Propriedades
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        #endregion

        public AlunoViewModel() { }

        public static ObservableCollection<Aluno> GetAluno()
        {
            if (AlunoList.Alunos == null)
                AlunoList.Alunos = new ObservableCollection<Aluno>();
            return AlunoList.Alunos;
        }

        public static void AddAluno(AlunoViewModel vmAluno)
        {
            var aluno = new Aluno()
            {
                Id = Guid.NewGuid(),
                RM = vmAluno.RM,
                Nome = vmAluno.Nome,
                Email = vmAluno.Email
            };
            AlunoList.Alunos.Add(aluno);
        }
    }
}
