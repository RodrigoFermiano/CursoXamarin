using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using XF.MVVMBasic.App.Models;
using XF.MVVMBasic.App.Services;

namespace XF.MVVMBasic.App.ViewModels
{
    public class AlunoViewModel
    {
       

        public async List<Aluno> GetAluno()
        {
            try
            {
                //var client = new ApiHelper().ObterHttClient();
                //string url = new ApiHelper().ObterUrl(CONTROLLER);
                

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
