using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;  //biblioteca, pacote de códigos
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPessoa.Application.Pessoa;
using WebApiPessoa.Repository;

namespace WebApiPessoa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly PessoaContext _context;
        public PessoaController(PessoaContext context)
        {
            _context = context;
        }


        //swagger
        /// <summary>
        /// Rota responsável por realizar o processamento de dados de uma pessoa
        /// </summary>
        /// <returns>Retorna os dados processados da pessoa</returns>
        /// <response code="200">Retorna os dados processados com sucesso</response>
        /// <response code="400">Erro de validação</response>


        [HttpPost]
        [Authorize]

        public PessoaResponse ProcessarInformacoesPessoa([FromBody] PessoaRequest request) //PessoaResponse = o que a api vai responder //ProcessarInformacoesPessoa() = nome do método //[FromBody] = vem do body //PessoaRequest = classe = o que vem do body //request = nome da váriavel, nome do parâmetro
        {
            var pessoaService = new PessoaService(_context);
            var pessoaResponse = pessoaService.ProcessarInformacoesPessoa(request);

            return pessoaResponse;
        }
    }
}
