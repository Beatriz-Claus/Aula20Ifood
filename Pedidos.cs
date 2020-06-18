namespace Aula20Ifood
{
    public class Pedido
    {
        public Pedido(string _nome, string _descricao, string _preco){
            this.Nome         = _nome;
            this.Descricao    = _descricao;
            this.Preco        = _preco;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
    }
}