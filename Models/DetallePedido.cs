using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models;

public class DetallePedido
{
    [Key]
    public int DetallePedidoID { get; set; }

    public decimal Precio { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal TotalAPagar { get; set; }

    public EstadoPedido EstadoPedidos { get; set; }

    public DateTime FechaHora { get; set; }

    public bool Eliminado { get; set; }


    public int ProductoID { get; set; }
    public virtual Producto? Producto { get; set; }

    public int ClienteID { get; set; }
    public virtual Cliente? Cliente { get; set; }

    public int PromocionID { get; set; }
    public virtual Promocion? Promocion { get; set; }
}