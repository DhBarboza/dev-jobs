namespace Jobs.API.Controllers
{
  using Jobs.API.Models;
  using Microsoft.AspNetCore.Mvc;

    [Route("api/job-vacancies")]
    [ApiController]
    public class JobVacanciesController : ControllerBase
    {
        // Consulta de informações:
        [HttpGet]
        public IActionResult GetAll()
        {
            
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // Cadastro de registros:
        [HttpPost]
        public IActionResult Post(AddJobVacancyInputModel model)
        {
            return Ok(); 
        }

        [HttpPut("{id}")]
        public IActionResult Put() 
        {
            return NoContent();
        }

    }
}