using System.ComponentModel;
using System.Reflection.Metadata;

namespace ProyectoProgra.Clases
{
    public class Compra
    {
        public Queue<MesasPlatino> cola_mesas = new Queue<MesasPlatino>();
        public Queue<VIP> cola_vip = new Queue<VIP>();
        public Queue<General> cola_general = new Queue<General>();
        public Queue<Tribuna> cola_tribuna = new Queue<Tribuna>();
        
        public string generarCorrelativo(string id, int tipo,int num)
        {
            string numCorrelativo=id[0].ToString()+id[1].ToString()+id[11].ToString()+id[12].ToString()+num+tipo;

            return numCorrelativo;
        }


    }
}
