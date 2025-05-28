using System;
class MainProduto
{
    public static void Main(string[] args)
    {
        Livro book = new Livro();
        book.titulo = "Psicologia Moderna";
        book.autor = "Jaderson de Gasper";
        book.preco = 59.90;
        book.estoque = 0;
        Console.WriteLine($"O nome do livro é: {book.titulo}, do autor {book.autor}");
        Console.WriteLine($"O valor deste livro é: {book.preco:F2}");
                                                                                                        /*Produto p1 = new Produto();
                                                                                                        p1.nome = "Alberto";
                                                                                                        Console.WriteLine($"O nome é: {p1.nome}");*/
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
    public string autor { get; set; }

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
    public int estoque { get; private set; }
}

                                                                                                    /*class Produto
                                                                                                    {
                                                                                                        public string _nome;
                                                                                                        public string nome
                                                                                                        {
                                                                                                            get
                                                                                                            {
                                                                                                                return _nome; // as variáveis internas da classe são os atributos
                                                                                                            }
                                                                                                            set
                                                                                                            {
                                                                                                                if (value.Length > 1) { 
                                                                                                                nome = value;
                                                                                                            }
                                                                                                                else
                                                                                                                {
                                                                                                                    Console.WriteLine($"Nome inválido");
                                                                                                                    throw new Exception("Nome do produto deve ter pelo menos 2 caracteres."); //quebra o código; para tratar o erro, usar try/catch
                                                                                                                }
                    
                                                                                                            } 
                                                                                                        }
                                                                                                    }*/




































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