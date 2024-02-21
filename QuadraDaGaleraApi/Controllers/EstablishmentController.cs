using Microsoft.AspNetCore.Mvc;
using QuadraDaGaleraApi.Dominio.Dtos.EstablishmentDtos;

namespace QuadraDaGaleraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstablishmentController : Controller
    {
        [HttpPost]
        [Route("NewEstablishment")]
        public IActionResult NewEstablishment(CreateEstablishmentDto createEstablishmentDto)
        {
            return Ok("Novo estabelecimento criado com sucesso");
        }

        [HttpPut]
        [Route("ChangeEstablishmentName")]
        public IActionResult ChangeUserName(EstablishmentNameUpdateDto establishmentNameUpdateDto)
        {
            return Ok("Nome do Estabelecimento alterado com sucesso");
        }

        [HttpPut]
        [Route("ChangeOpeningTime")]
        public IActionResult ChangeOpeningTime(OpeningTimeUpdateDto openingTimeUpdateDto)
        {
            return Ok("Horário de abertura do Estabelecimento alterado com sucesso");
        }

        [HttpPut]
        [Route("ChangeCloseTime")]
        public IActionResult ChangeCloseTime(CloseTimeUpdateDto closeTimeUpdateDto)
        {
            return Ok("Horário de fechamento do Estabelecimento alterado com sucesso");
        }

        [HttpPut]
        [Route("ChangeSoccerFieldQuantity")]
        public IActionResult ChangeSoccerFieldQuantity(SoccerFieldQuantityUpdateDto soccerFieldQuantityUpdateDto)
        {
            return Ok("Quantidade de quadras do Estabelecimento alterado com sucesso");
        }
    }
}




//Establishment