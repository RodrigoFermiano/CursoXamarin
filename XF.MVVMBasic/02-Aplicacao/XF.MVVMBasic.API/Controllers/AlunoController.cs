using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XF.MVVMBasic.Entidades;
using XF.MVVMBasic.Negocio;

namespace XF.MVVMBasic.API.Controllers
{
    [Route("api/[controller]")]
    public class AlunoController : Controller
    {
        AlunoBLL alunoBLL = new AlunoBLL();

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Aluno> lista = alunoBLL.GetAlunos();

            if (lista.ToList().Count > 0)
            {
                return Ok(lista);
            }
            else
            {
                return Ok(new List<Aluno>());
            }

            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Aluno item = alunoBLL.GetAlunos().Where(x=>x.Id.Equals(id)).FirstOrDefault();

            if (item != null)
            {
                return Ok(item);
            }
            else
            {
                return Ok(new Aluno());
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Aluno value)
        {
            bool retorno = alunoBLL.PostAluno(value);

            if (retorno)
            {
                return Ok();
            }

            return  BadRequest("Algo deu errado!");

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Aluno value)
        {
            bool retorno = alunoBLL.PutAluno(id, value);

            if (retorno)
            {
                return Ok();
            }

            return BadRequest("Algo deu errado!");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
