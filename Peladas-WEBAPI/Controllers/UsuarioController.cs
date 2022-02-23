using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Peladas_WEBAPI.Data;
using Peladas_WEBAPI.Models;

namespace Peladas_WEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IRepository _repo;
        public UsuarioController(IRepository repo)
        {
            _repo = repo;

        }
             
        [HttpGet]
        public async Task<IActionResult> Get( )
        {
            try
            {
                var result = await _repo.GetAllUsuarioAsync(true);

                return Ok(result);
            }
            catch (Exception ex)
            {
                //tratamento do exceção
                return BadRequest($"Erro {ex.Message}");
            }
        }

        
        [HttpGet("{UsuarioID}")]
       public async Task<IActionResult> GetUsuarioId(int usuarioId)
        {
            try
            {
                var result = await _repo.GetAllUsuarioAsyncById(usuarioId, true);

                return Ok(result);
            }
            catch (Exception ex)
            {
                //tratamento do exceção
                return BadRequest($"Erro {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> post(Usuario model)
        {
            try
            {
                _repo.Add(model);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }                
            }
            catch (Exception ex)
            {   //eroo tratado
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }
    
    

    }
}
