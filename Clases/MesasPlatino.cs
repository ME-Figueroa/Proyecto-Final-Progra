namespace ProyectoProgra.Clases
{
    public class MesasPlatino : Boletos
    {
        public string? NumeroMesa { get; set; }

        public MesasPlatino() {
            this.tipoBoleto = "Mesa Platino";
            this.costo = 4290;
        }
    }
}
