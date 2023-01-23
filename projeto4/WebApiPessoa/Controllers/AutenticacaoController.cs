using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace WebApiPessoa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutenticacaoController : ControllerBase
    {
        //método
        public string GerarTokenJwt()
        {
            var issuer = "var";  //quem está emitindo o token
            var audience = "var";  //destinatário da api
            var key = "1c93a5c9-1b8d-4f3c-ba71-65954542cc4e";

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        }
    }
}