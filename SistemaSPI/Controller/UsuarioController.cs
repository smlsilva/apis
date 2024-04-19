using Microsoft.AspNetCore.Mvc;
using model.usuario;

namespace controller.usuario;

[ApiController]
[Route("/v1/api/usuario/")]
public class Usuario : ControllerBase {

    [HttpGet]
    public IActionResult GetAll(UsuarioModel usuarioModel) {
        return Ok();
    }
    [HttpPost]
    public IActionResult PostAll(UsuarioModel usuarioModel) {
        return Ok();
    }
    [HttpPut]
    public IActionResult PutAll(UsuarioModel usuarioModel) {
        return Ok();
    }
    [HttpDelete]
    public IActionResult DeleteAll(UsuarioModel usuarioModel) {
        return Ok();
    }
    
}