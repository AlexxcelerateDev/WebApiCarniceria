using System.ComponentModel.DataAnnotations;

namespace WebApiCarniceria.Carniceria
{
    public class Venta
    {
        [Key]
        public int Id_venta { get; set; }
        public int Id_cliente { get; set; }
        public Cliente cliente { get; set;}

        public string fecha_venta { get; set; }

        public int cantidad { get; set; }
    }
}
