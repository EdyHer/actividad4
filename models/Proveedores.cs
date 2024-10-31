namespace ApiEmpresa.Models;

public class Proveedores{
    public Int32 Id { get; set; }
    public string? nit { get; set; }
    public string? proveedor { get; set; }
    public string? direccion { get; set; }
    public string? razon_social { get; set; }
    public DateTime? fecha_creacion { get; set; }
}