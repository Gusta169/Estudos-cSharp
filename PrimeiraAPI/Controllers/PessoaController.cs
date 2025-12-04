using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Data;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Controllers
{
    [ApiController] //é oque ira controlar toda a API
    [Route("api/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly AppDbContext _appDbContext; //Variavel que ira acessar o banco de Dados
        public PessoaController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpPost]
        public async Task<IActionResult> AddPessoa(Pessoa pessoa)
        {
            _appDbContext.FirstAPI.Add(pessoa);
            await _appDbContext.SaveChangesAsync();

            return Ok(Pessoa);
        }
    }
}
