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

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            return Ok("Usuário deletado com sucesso");
        }
    }
}
