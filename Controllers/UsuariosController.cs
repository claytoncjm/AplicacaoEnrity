using AplicacaoEnrity.Repositoy;
using Ecomerci;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoEnrity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuariosController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var ListaUsuarios = _repository.Get();

            return Ok(ListaUsuarios);
        }

        [HttpGet("{id}")]
        public IActionResult Get (int id)
        {
            var usuario = _repository.Get(id);
            if(usuario ==null)
            {
                return NotFound("Karaca em, usuario nao encontradoww");
            }

            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Usuario usuario)
        {
            usuario.Id = 0;
            _repository.Add(usuario);
            
            return Ok(usuario);
        }

        [HttpPut("{id}")]

        public IActionResult Update([FromBody]Usuario usuario, int id)
        {
            _repository.Update(usuario);

            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (int id)
        {
            _repository.Delete(id);

            return Ok();
        }




    }
}
