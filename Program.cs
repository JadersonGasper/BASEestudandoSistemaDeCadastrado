using System;
using System.Text;
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

class Livro
{
    public string _titulo;
    public string titulo
    {
        get
        {
            return _titulo;
        }
        set
        {
            if (value.Length > 2) // neste contexto, o Length é uma propriedade!
            {
                _titulo = value;
            }
            else
            {
                Console.WriteLine("Nome inválido.");
            }
        }
    }
    public double _preco;
    public double preco
    {
        get
        {
            return _preco;
        }
        set
        {
            if (value > 0)
            {
                _preco = value;
            }
            else
            {
                 Console.WriteLine("Preço inválido");
            }
        }
    }
    public string autor { get; set; }
    // //  // //  // //  // //  // //  // //  // //  // //  // //  
    public int estoque { get; private set; }
    public Livro() // construtor padrão
    {
        this.estoque = 0;
    }
    public Livro(string titulo, double preco, string autor)
    {
        this.titulo = titulo;
        this.preco = preco;
        this.autor = autor;
        this.estoque = 0;
        
    }
    public int Vender(int qtd)
    {
        if (this.estoque - qtd >= 0)
            this.estoque -= qtd;

        return this.estoque;
    }
    public int Comprar(int qtd)
    {
        this.estoque += qtd;
        return this.estoque;
    }
    public string ObterTexto()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"\nTitulo: {this.titulo}\n");
        sb.Append($"\nAutor: {this.autor}\n");
        sb.Append($"Preço: {this.preco}\n");
        sb.Append($"Estoque: {this.estoque}\n");
        return sb.ToString();
    }
    // //  // //  // //  // //  // //  // //  // //  // //  // //  
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