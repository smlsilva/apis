public interface ISala {

    void AddSala(SalaModel sala);
    void RemoveSala(SalaModel sala);
    void AtualizarSala(SalaModel sala);
    public List<SalaModel> ListarSalas();
}