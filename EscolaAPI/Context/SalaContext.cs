
using Microsoft.AspNetCore.Http.HttpResults;

public class SalaContext : ISala
{

    Connection _salaContext = new Connection();
    public void AddSala(SalaModel sala)
    {
        _salaContext.salaModels.Add(sala);
        _salaContext.SaveChanges();
    }

    public void AtualizarSala(SalaModel sala)
    {
        _salaContext.salaModels.Update(sala);
        _salaContext.SaveChanges();
    }

    public List<SalaModel> ListarSalas()
    {
        return _salaContext.salaModels.ToList();
    }

    public void RemoveSala(SalaModel sala)
    {
        _salaContext.salaModels.Remove(sala);
        _salaContext.SaveChanges();
    }
}