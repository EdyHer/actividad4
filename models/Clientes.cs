namespace ApiEmpresa.Models;

public class Clientes{
    public Int32 Id { get; set; }
    public string? nombres { get; set; }
    public string? apellidos { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    public DateTime? fecha_nacimiento { get; set; }
}