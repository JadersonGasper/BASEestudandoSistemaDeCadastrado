using System;
class MainProduto
{
    public static void Main(string[] args)
    {
        Produto p1 = new Produto();
        p1.nome = "A";
        Console.WriteLine($"O nome é: {p1.nome}");
    }
}

class Produto
{
    public string _nome;
    public string nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (value.Length > 1) { 
            nome = value;
        }
            else
            {
                Console.WriteLine($"Nome inválido");
                //throw new Exception("Nome do produto deve ter pelo menos 2 caracteres."); //quebra o código; para tratar o erro, usar try/catch
            }
                    
        } 
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