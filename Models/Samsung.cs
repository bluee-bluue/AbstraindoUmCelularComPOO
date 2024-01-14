namespace Abstraindo_um_Celular_com_POO.Models
{
    // Herdando da classe "Smartphone"
    public class Samsung : Smartphone
    {
        public Samsung(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Samsung");
        }
    }
}
