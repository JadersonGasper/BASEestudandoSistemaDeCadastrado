class Produto
{
    private string nome;

    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            if (value.Length > 1)
                nome = value;
            else
                throw new Exception("Nome do produto ter pelo menos 2 caracteres");
        }
    }
    public double Preco { get; set; }

    public int Estoque { get; private set; }

    public Produto()
    {
        this.Estoque = 0;
    }

    public Produto(string nome, double preco)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Estoque = 0;
    }
    public int Vender(int qt)
    {

    }
}

/*using System.Text;
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
    public string _autor;
    public string autor { get; set; }
    // //  // //  // //  // //  // //  // //  // //  // //  // //  
    public int estoque { get; private set; }
    public Livro() // construtor padrão; mesmo nome da classe, não tem retorno, é público.
    {
        this.estoque = 0;
    }
    public Livro(string _titulo, double _preco, string _autor)
    {
        this._titulo = titulo;
        this._preco = preco;
        this._autor = autor;
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