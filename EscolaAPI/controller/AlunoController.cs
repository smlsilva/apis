using escola.model.aluno;
using Microsoft.AspNetCore.Mvc;
namespace escola.controller.aluno;

[ApiController]
[Route("/v1/api/aluno/")]
public class AlunoController : ControllerBase {

    private readonly IAluno _aluno;

    public AlunoController(IAluno aluno) {
        this._aluno = aluno;
    }
    
    [HttpGet]
    public IActionResult Get() {
        return Ok(_aluno.get());
    }

    [HttpPost]
    public IActionResult Post(AlunoModel alunoModel) {
        var dadosTratados = new AlunoModel(null, alunoModel.nome, alunoModel.sobrenome, alunoModel.idade, alunoModel.nota, alunoModel.turma);
        _aluno.add(dadosTratados);
        return Ok("Salvo com Sucesso!");
    }

    [HttpPut]
    public IActionResult Put(AlunoModel alunoModel) {
        var dadosTratados = new AlunoModel(alunoModel.Id, alunoModel.nome, alunoModel.sobrenome, alunoModel.idade, alunoModel.nota, alunoModel.turma);
        _aluno.atualizar(dadosTratados);
        return Ok("Atualizado com Sucesso!");
    }

    [HttpDelete]
    public IActionResult Delete(int id) {
        var dadosTratados = new AlunoModel(id, null, null, null, null, null);
        _aluno.deletar(dadosTratados);
        return Ok("Deletado com Sucesso!");
    }
}