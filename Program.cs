using System;
class MainProduto
{
    public static void Main(string[] args)
    {
        Livro book = new Livro();
        book.titulo = "Psicologia Moderna";
        book.autor = "Jaderson de Gasper";
        book.preco = 59.90;
        book.Comprar(10);
        Console.WriteLine(book.ObterTexto());
    }
}
































/*using System;

class MainProduto // "molde do bolo"
{
    public static void Main(string[] args)
    {
        Produto p1 = new Produto(); // Produto p1 = "bolo chamado p1"; // new Produto() = "molde para assar outro bolo"
        p1._nome = "Alberto";
        Console.WriteLine($"O nome é: {p1._nome}");
    }
}

class Produto
{
    public string _nome;
    public string nome
    {
        get
        {
            return nome;
        }
        set
        {
            nome = value;
        }
    }
}*/