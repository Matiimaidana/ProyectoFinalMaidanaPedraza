using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models;

public class Pedido
{
    [Key]
    public int PedidoID { get; set; }

    public string? Domicilio { get; set; }

    public decimal TotalAPagar { get; set; }

    public bool Eliminado{ get; set; }

    public decimal Cantidad { get; set; }

    public DateTime FechaHora { get; set; }

    public EstadoPedido EstadoPedidos { get; set; }

    public int ProductoID { get; set; }
    public virtual Producto? Producto { get; set; }

    public int ClienteID { get; set; }
    public virtual Cliente? Cliente { get; set; }

    public int PromocionID { get; set; }
    public virtual Promocion? Promocion { get; set; }
}

public enum EstadoPedido 
{
    Preparacion = 1,
    Enviado = 2,
    Entregado = 3,
    Cancelado = 4
}