namespace ProyectoProgra.Clases
{
    public class General : Boletos
    {
        public bool EsZonaDePie { get; set; } = true;
        public static int cantidadBoletosGeneral{ get; set; } = 80;
        public int NumeroBoleto { get; set; }


        public General()
        {
            this.tipoBoleto = "Areá General";
            this.costo = 702;
        }
    }
}
