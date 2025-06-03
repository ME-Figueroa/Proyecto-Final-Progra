namespace ProyectoProgra.Clases
{
    public class General : Boletos
    {
        public bool EsZonaDePie { get; set; } = true;

        public General()
        {
            this.tipoBoleto = "Areá General";
            this.costo = 702;
        }
    }
}
