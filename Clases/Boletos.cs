using System.ComponentModel.DataAnnotations;

namespace ProyectoProgra.Clases
{
    public class Boletos
    {
        public  int correlativo {  get; set; }
        public string tipoBoleto { get; set; }


        [Required][StringLength(13,ErrorMessage ="Ingrese un numero de DPI valido")]
        public string dpi { get; set; }

        [Required] public string? nombres { get; set; }
        [Required] public string? apellidos { get; set; }
        public DateTime fechaCompra {  get; set; } = DateTime.Now;
        [Required] public string? correoElectronico { get; set; } 

        public decimal costo { get; set; }
    }
}
