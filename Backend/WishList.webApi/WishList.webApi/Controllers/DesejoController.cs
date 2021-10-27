using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishList.webApi.Domains;
using WishList.webApi.Interfaces;
using WishList.webApi.Repositories;

namespace WishList.webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class DesejoController : ControllerBase
    {
        private IDesejoRepository _desejoRepository { get; set; }
        public DesejoController()
        {
            _desejoRepository = new DesejoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_desejoRepository.Listar());
        }

        [HttpPost]
        public IActionResult Post(Desejo novoDesejo)
        {
            _desejoRepository.Cadastrar(novoDesejo);
            return StatusCode(201);
        }
    }
}
