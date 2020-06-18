using System;
namespace Aula20Ifood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string resposta;

        public void MostrarDados(){
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"\nConfirme seus dados: \nNome: {Nome} \nEndereço de Entrega: {Endereco} \nResponda com Sim ou Não.");
            Console.ResetColor();
        }
    }
}