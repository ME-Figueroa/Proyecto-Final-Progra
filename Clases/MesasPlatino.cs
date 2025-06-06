using System.ComponentModel.DataAnnotations;

namespace ProyectoProgra.Clases
{
    public class MesasPlatino : Boletos
    {
        [Required][Range(1, 5, ErrorMessage = "Ingrese un numero de mesa valido")]
        public int NumeroMesa { get; set; }
        public static int cantidadBoletosMesas { get; set; } = 30;

        public MesasPlatino() {
            this.tipoBoleto = "Mesa Platino";
            this.costo = 4290;
        }
    }
}
