namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string modelo;
        private string imei;
        private int memoria;
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public string ShowModelo()
        {
            return modelo;
        }

        public string ShowImei()
        {
            return imei;
        }
        public int ShowMemoria()
        {
            return memoria;
        }

        public abstract void AboutPhone();
        public abstract void InstalarAplicativo(string nomeApp);
    }
}