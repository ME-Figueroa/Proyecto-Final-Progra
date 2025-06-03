namespace ProyectoProgra.Clases
{
    public class VIP : Boletos
    {
        public string? numEstacionamiento { get; set; }

        public VIP()
        {
            this.tipoBoleto = "VIP";
            this.costo = 1755;
        }

    }
}
