using Microsoft.AspNetCore.Mvc;
using QuadraDaGaleraApi.Dominio.Dtos;

namespace QuadraDaGaleraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Usuário retornado com sucesso");
        }

        [HttpPut]
        [Route("ChangeDateOfBirth")]
        public IActionResult ChangeDateOfBirth(DateOfBirthUpdateDto dateOfBirthUpdateDto)
        {
            return Ok("Data de nascimento alterada com sucesso");
        }

        [HttpPut]
        [Route("ChangeTelephone")]
        public IActionResult ChangeTelephone(TelephoneUpdateDto telephoneUpdateDto)
        {
            return Ok("Número de telefone alterado com sucesso");
        }

        [HttpPut]
        [Route("ChangeIsWhatsapp")]
        public IActionResult ChangeIsWhatsapp(IsWhatsAppUpdateDto isWhatsAppUpdateDto)
        {
            return Ok("É whatsapp alterado com sucesso");
        }

        [HttpPut]
        [Route("ChangeUserName")]
        public IActionResult ChangeUserName(UserNameUpdateDto userNameUpdateDto)
        {
            return Ok("Nome de usuário alterado com sucesso");
        }

        [HttpDelete]
        public IActionResult RemoveUser(string id)
        {
            return Ok("Usuário deletado com sucesso");
        }
    }
}
