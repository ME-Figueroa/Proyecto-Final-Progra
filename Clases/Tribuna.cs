namespace ProyectoProgra.Clases
{
    public class Tribuna : Boletos
    {
        public string? NumeroAsiento { get; set; }

        public Tribuna()
        {
            this.tipoBoleto = "Tribuna";
            this.costo = 429;
        }
    }
}
