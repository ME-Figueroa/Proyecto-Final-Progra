using System.ComponentModel.DataAnnotations;

namespace ProyectoProgra.Clases
{
    public class Tribuna : Boletos
    {
        [Required]
        [Range(1, 100, ErrorMessage = "Ingrese un numero de estacionamiento valido")]

        public int NumeroAsiento { get; set; }
        public static int cantidadBoletosTribuna { get; set; } = 100;


        public Tribuna()
        {
            this.tipoBoleto = "Tribuna";
            this.costo = 429;
        }
    }
}
