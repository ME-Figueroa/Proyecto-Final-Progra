using ProyectoProgra.Clases;

public class ColaDeBoletosService<T> where T : Boletos
{
    private Queue<T> cola = new();
    private int stock;

    public ColaDeBoletosService(int stockInicial)
    {
        stock = stockInicial;
    }

    public void Encolar(T boleto) => cola.Enqueue(boleto);
    public T? Atender() => cola.Count > 0 && stock > 0 ? cola.Dequeue() : null;
    public int Restantes() => stock;
    public int EnCola() => cola.Count;

    public string Procesar()
    {
        if (stock <= 0) return "❌ Boletos agotados.";
        if (cola.Count == 0) return "⏳ No hay personas en cola.";

        var boleto = cola.Dequeue();
        stock--;
        return $"✅ Boleto emitido para {boleto.nombres} {boleto.apellidos}";
    }
}
