using System.ComponentModel.DataAnnotations;

namespace WebApiCarniceria.Carniceria
{
    public class Cliente
    {
        [Key]
        public int Id_cliente { get; set;}

        public string Nombre { get; set; }

        public string apellido { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }
    }
}
