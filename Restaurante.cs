namespace Aula20Ifood
{
    public class Restaurante
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public void MostrarDados(){
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
            System.Console.WriteLine($"Informações do Restaurante: \n{Nome} \n{Endereco}");
            System.Console.ResetColor();
        }
    }
}