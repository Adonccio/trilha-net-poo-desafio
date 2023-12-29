namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, int memoria, string imei) : base(numero, modelo, memoria, imei)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string app) {
            Console.WriteLine($"Instalando {app} através da Apple Store");
        }
    }
}