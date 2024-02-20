//Aqui na composição, o objeto "Item" é totalmente dependente do "CarrinhoCompra" para existir.

using System;

// Classe CarrinhoCompra representa um objeto composto
class CarrinhoCompra
{
    // A classe CarrinhoCompra contém um objeto da classe Item
    private Item item;

    // Construtor
    public CarrinhoCompra(string descricao, double preco)
    {
        item = new Item(descricao, preco);
    }

    // Método para obter o preço total do carrinho
    public double ObterPrecoTotal()
    {
        return item.Preco;
    }

    // Classe Item representa um componente do objeto composto
    private class Item
    {
        public string Descricao { get; }
        public double Preco { get; }

        // Construtor
        public Item(string descricao, double preco)
        {
            Descricao = descricao;
            Preco = preco;
        }
    }
}

// Classe principal
class Program
{
    static void Main(string[] args)
    {
        // Criando um carrinho de compras com um item
        CarrinhoCompra carrinho = new CarrinhoCompra("Livro", 25.99);

        // Exibindo o preço total do carrinho
        Console.WriteLine($"Preço total do carrinho: ${carrinho.ObterPrecoTotal()}");
    }
}