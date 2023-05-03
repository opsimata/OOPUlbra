using System;
using System.Collections.Generic;

interface IImpressoraDeCodigoDeBarras
{
    void ImprimirEtiqueta(Produto produto);
}

class Elgin : IImpressoraDeCodigoDeBarras
{
    public void ImprimirEtiqueta(Produto produto)
    {
        Console.Write("\n\n");
        Console.WriteLine($"Imprimindo etiqueta do produto {produto.Id} na impressora Elgin");
        Console.WriteLine($"Código de barras: {produto.CodBarras}");
        Console.WriteLine($"Preço: R${produto.Preco}");
        Console.WriteLine($"Configurações padrão:");
        Console.WriteLine($"- Resolução: 300dpi");
        Console.WriteLine($"- Tamanho da etiqueta: 10cm x 5cm");
        Console.WriteLine($"- Tipo de etiqueta: Papel adesivo");
        Console.WriteLine($"Etiqueta impressa com sucesso!");
    }
}

class Zebra : IImpressoraDeCodigoDeBarras
{
    public void ImprimirEtiqueta(Produto produto)
    {
        Console.Write("\n\n");
        Console.WriteLine($"Imprimindo etiqueta do produto {produto.Id} na impressora Zebra");
        Console.WriteLine($"Código de barras: {produto.CodBarras}");
        Console.WriteLine($"Preço: R${produto.Preco}");
        Console.WriteLine($"Configurações padrão:");
        Console.WriteLine($"- Resolução: 600dpi");
        Console.WriteLine($"- Tamanho da etiqueta: 15cm x 7cm");
        Console.WriteLine($"- Tipo de etiqueta: Poliéster");
        Console.WriteLine($"Etiqueta impressa com sucesso!");
    }
}

class Produto
{
    public int Id { get; set; }
    public string CodBarras { get; set; }
    public decimal Preco { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var impressoras = new List<IImpressoraDeCodigoDeBarras>();
        impressoras.Add(new Elgin());
        impressoras.Add(new Zebra());

        Console.WriteLine("Informe o código de barras a ser impresso:");
        string codBarras = Console.ReadLine();

        var produto = new Produto()
        {
            Id = 1,
            CodBarras = codBarras,
            Preco = 10.99m
        };

        foreach (var impressora in impressoras)
        {
            impressora.ImprimirEtiqueta(produto);
        }

        Console.WriteLine("\n");
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
