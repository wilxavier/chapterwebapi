using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chapter.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly LivroRespository _livroRepository;
        public LivrosController(LivroRespository livroRepository)
        {
            _livroRepository = livroRepository; 
        }
        [HttpGet]
        public IAction IActionResult Listar()
        {
            return Ok(_livroRepository.Listar());
        }
    }
}