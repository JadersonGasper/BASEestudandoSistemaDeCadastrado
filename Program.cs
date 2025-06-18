using System;
using System.Text; // pacote que contém o uso do StringBuilder
class MainClass
{
    public static void Main(string[] args)
    {
        List<string> carros = new List<string>();

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        foreach (string c in carros)
        {
            Console.WriteLine("Carro: {1}", c);
        }

    }
}