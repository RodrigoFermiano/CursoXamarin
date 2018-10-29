using System;
using System.Collections.Generic;
using XF.MVVMBasic.Dados;
using XF.MVVMBasic.Entidades;

namespace XF.MVVMBasic.Negocio
{
    public class AlunoBLL
    {

        AlunoDAL alunoDAL = new AlunoDAL(); 
        public List<Aluno> GetAlunos()
        {
            return alunoDAL.GetAlunos();
        }

        public bool PostAluno(Aluno aluno)
        {
            return alunoDAL.PostAluno(aluno);
        }

        public bool PutAluno(int id, Aluno aluno)
        {
            return alunoDAL.PutAluno(id , aluno);
        }

        public bool DeleteAluno(int id)
        {
            return alunoDAL.DeleteAluno(id);
        }
    
    }
}
