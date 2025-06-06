using System.ComponentModel.DataAnnotations;

namespace ProyectoProgra.Clases
{
    public class VIP : Boletos
    {
        [Required][Range(1,40,ErrorMessage ="Ingrese un numero de estacionamiento valido")]
        public int numEstacionamiento { get; set; }
        public static int cantidadBoletosVIP { get; set; } = 40;


        public VIP()
        {
            this.tipoBoleto = "VIP";
            this.costo = 1755;
        }

    }
}
