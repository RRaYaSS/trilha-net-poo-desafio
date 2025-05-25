namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void AboutPhone()
        {
            Console.WriteLine($"Seu celular é da marca Iphone tem o modelo: {ShowModelo()}, tem o imei de {ShowImei()} e tem {ShowMemoria()} de memoria ram");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no celular Iphone");
        }
    }
}