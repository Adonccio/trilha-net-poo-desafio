namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo , int memoria, string imei) : base (numero, modelo, memoria, imei)
        {
            
        }
        public override void InstalarAplicativo(string app) {
            Console.WriteLine($"Instalando {app} através da Google Play Store");
        }
    }
}