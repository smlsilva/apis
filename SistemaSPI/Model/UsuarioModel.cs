using System.ComponentModel.DataAnnotations.Schema;

namespace model.usuario;

[Table("usuarios")]
public class UsuarioModel {
    
    public int id {get; private set; }
    public string? foto {get; set; }
    public string? empresa {get; private set; }
    public string? contrato {get; private set; }
    public string? cluster {get; private set; }
    public Int32 area {get; private set; }
    public string? cargo {get; private set; }

    public UsuarioModel(int id, string? foto, string? empresa, string? contrato, string? cluster, Int32 area, string? cargo) {

        this.id = id;
        this.foto = foto;
        this.empresa = empresa;
        this.contrato = contrato;
        this.cluster = cluster;
        this.area = area;
        this.cargo = cargo;

    }

}