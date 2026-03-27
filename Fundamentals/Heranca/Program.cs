using System;

class Veiculo // Classe base
{
    public string Marca { get; set; }
    public string Cor { get; set; }
    public int Velocidade { get; set; }
    public bool Ligado { get; set; }

    public Veiculo(string marca, string cor, int velocidade, bool ligado)
    {
        Marca = marca;
        Cor = cor;
        Velocidade = velocidade;
        Ligado = ligado;
    }  

    public string GetLigado()
    {
        return Ligado ? "Sim" : "Não";
    }
}

class Carro : Veiculo 
{
    public string modelo;
    public Carro(string modelo)
        : base("Audi", "Preto", 200, true)
    {
        this.modelo = modelo;
    }
}

class Heranca
{
static void Main()
    {
        Carro c1 = new Carro("TT");

        Console.WriteLine(c1.modelo);
        Console.WriteLine(c1.Marca);
        Console.WriteLine(c1.Cor);
        Console.WriteLine(c1.GetLigado());
        Console.WriteLine(c1.Velocidade);

    }
}