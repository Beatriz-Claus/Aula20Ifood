using System;

namespace Aula20Ifood
{
    class Program
    {
        static void Main(string[] args)
        {       
            Restaurante info = new Restaurante();
            info.Nome = "Cantinho da Vovó";
            info.Endereco = "Rua Almerindo Alziro Paganini, 118, 03671-000 São Paulo";
            info.MostrarDados();

            //
            Cliente cliente = new Cliente();
            cliente.Nome = "Jacira";
            cliente.Endereco = "Jd. Antartica";

            string resposta = null;

            while(resposta != "Sim"){
            cliente.MostrarDados();
            resposta = Console.ReadLine();
            }

            //
            Console.ForegroundColor = ConsoleColor.Red;
            Pedido Lasanha = new Pedido("Lasanha", "Sabores: Calabresa/Queijo/Bolonhesa", "Porção Individual: R$15" );
            System.Console.WriteLine($"\n{Lasanha.Nome}\n{Lasanha.Descricao}\n{Lasanha.Preco}");
            Console.ResetColor();
        }
    }
}