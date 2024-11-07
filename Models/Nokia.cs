namespace DesafioPOO.Models
{
    
    public class Nokia :  Smartphone
    {
        public Iphone (string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
        Console.WriteLine 
          ($"O celular está instalando o aplicativo {nomeApp} pela playstore, loja exclusiva do android ");
        }
    }
}