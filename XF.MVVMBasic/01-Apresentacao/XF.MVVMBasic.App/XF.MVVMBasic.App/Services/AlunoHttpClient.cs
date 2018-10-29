using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XF.MVVMBasic.App.Models;

namespace XF.MVVMBasic.App.Services
{
    public class AlunoHttpClient
    {
        private const string CONTROLLER = "Aluno";

        private static Lazy<AlunoHttpClient> _lazy = new Lazy<AlunoHttpClient>(() => new AlunoHttpClient());

        public static AlunoHttpClient Current { get => _lazy.Value; }

        private readonly HttpClient _httpClient;

        public AlunoHttpClient()
        {
            _httpClient = new HttpClient();
        }

       public async Task<List<Aluno>> GetAlunoAsync()
        {
            List<Aluno> lista = new List<Aluno>();


            using (var response = await _httpClient.GetAsync($"http://localhost:3902/api/{CONTROLLER}/json"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    lista = JsonConvert.DeserializeObject<List<Aluno>>(result);
                }
            }


            return lista;
        }
    }
}
