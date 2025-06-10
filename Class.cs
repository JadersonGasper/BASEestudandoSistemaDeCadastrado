using System.Text;

class Produto
{                        // atributo armazena valor
    private string nome; // 1. private só será visível para a CLASSE
                         // Errata: forma de usar a variável na classe Main(?)
    public string Nome //! propriedades não armazenam valor; são a ponte entre o atributo
    {
        get
        {
            return nome; //.ToUpper(); = trabalha com o valor da variável
        }
        set
        {
            if (value.Length > 1)
                nome = value;
            else
                throw new Exception("Nome do produto ter pelo menos 2 caracteres.");
        }
    }

    /*private double preco;
    public double Preco
    {
        get { return preco; }
        set { preco = value; }
    }*/
    // a linha abaixo equivale nos bastidores a linha acima.
    public double Preco { get; set; }

    public int Estoque { get; private set; } //private: outras partes do código
                                             //possam consultar o estoque,
                                             //mas não possam alterá-lo diretamente —
                                             //só a própria classe pode fazer isso por
                                             //meio de métodos como Vender() ou Repor().
    public Produto() //é um método construtor por ser public pois não pode haver
                     //dois "Produto"; se fosse o caso, este teria que ser private.
                     //não possui retorno, é público e tem o mesmo nome da classe =
                     //método construtor                     
    {
        this.Estoque = 0; // todo novo obj. do tipo produto, terá o estoque = 0.
    }

    public Produto(string nome, double preco)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Estoque = 0; // aqui, o 'this.' não se faz necessário, pois não há um
                          // mesmo 'Estoque' no atributo da classe
    }

    public int Vender(int qtde)
    {
        if (this.Estoque - qtde >= 0)
        {
            this.Estoque -= qtde;
        }
        return this.Estoque;
    }

    public int Comprar(int qtde)
    {
        this.Estoque += qtde;
        return this.Estoque;
    }

    public string ObterTexto() //método
    {
        StringBuilder sb = new StringBuilder(); //instanciando um objeto
        sb.Append($"\nNome: {this.Nome}\n");
        sb.Append($"Preço: {this.Preco}\n");
        sb.Append($"Estoque: {this.Estoque}\n");
        return sb.ToString();
    }
}