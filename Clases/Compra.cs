using System.ComponentModel;
using System.Reflection.Metadata;
using QRCoder;

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

        public string generarQR(string num)
        {
            QRCodeGenerator generarqr = new QRCodeGenerator();
            var qr = generarqr.CreateQrCode(num, QRCodeGenerator.ECCLevel.Q);
            BitmapByteQRCode bitmap = new BitmapByteQRCode(qr);
            byte[] arraybytes = bitmap.GetGraphic(10);

            // Convertir a base64 directamente
            string qrtexto = Convert.ToBase64String(arraybytes);

            // Retornar string listo para usar en la etiqueta <img>
            string imgData = $"data:image/png;base64,{qrtexto}";

            return imgData;
        }
    }
}
