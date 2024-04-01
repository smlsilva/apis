using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/v1/api/sala/")]
public class SalaController : ControllerBase {

    private readonly ISala _sala;

    public SalaController(ISala isala) {
        this._sala = isala;
    }

    [HttpGet]
    public IActionResult Get() {
        return Ok(_sala.ListarSalas());
    }
    
    [HttpPost]
    public IActionResult Post(SalaModel salaModel) {
        _sala.AddSala(salaModel);
        return Ok("Incluido com Sucesso!");
    }
    
    [HttpPut]
    public IActionResult Put(SalaModel salaModel) {
        _sala.AtualizarSala(salaModel);
        return Ok("Atualizado com Sucesso!");
    }
    [HttpDelete]
    public IActionResult Delete(SalaModel salaModel) {
        _sala.RemoveSala(salaModel);
        return Ok("Sala foi excluída!");
    }
}
