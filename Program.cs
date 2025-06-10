using System;
using System.Text; // pacote que contém o uso do StringBuilder
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Classes, " +
            "Objetos e Escopos de Visibilidade");

        Produto p1 = new Produto(); // toda classe por padrão tem o método construtor
                                    // que é herdado de uma classe ancestral (futuro)
                                    // Toda vez que é digitado este código, um objeto
                                    // é criado utilizando o método construtor;
        p1.Nome = "Banana";
        p1.Preco = 3.99;
        p1.Comprar(20);
        p1.Vender(3);
        Console.WriteLine(p1.ObterTexto());

        Produto p2 = new Produto("Larissa", 4.75);
        p2.Comprar(100);
        p2.Vender(17);
        Console.WriteLine(p2.ObterTexto());

        Produto p3 = new Produto("Abacaxi", 3.25);
        p3.Comprar(50);
        p3.Vender(21);
        Console.WriteLine(p3.ObterTexto());
    }
}