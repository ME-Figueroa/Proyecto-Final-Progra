namespace ProyectoProgra.Clases
{
    public class Devolucion
    {
        public string? nombre {  get; set; }

        public int ? id { get; set; }

        public Stack<Devolucion> devoluciones = new Stack<Devolucion>();
    }
}
