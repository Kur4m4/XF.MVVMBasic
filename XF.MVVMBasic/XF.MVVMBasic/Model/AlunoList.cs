using System;
using System.Collections.ObjectModel;
using System.Text;

namespace XF.MVVMBasic.Model
{
    class AlunoList
    {
        public static ObservableCollection<Aluno> Alunos { get; set; }
    }
}
