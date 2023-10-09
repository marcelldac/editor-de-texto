using System;
using System.IO;

namespace TextEditor
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("O que você deseja fazer?");
      Console.WriteLine("1 - Abrir arquivo.");
      Console.WriteLine("2 - Criar novo arquivo.");
      Console.WriteLine("0 - Sair arquivo.");

      short opcao = short.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 0: Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break;
      }
    }

    static void Abrir()
    {

    }

    static void Editar()
    {
      Console.Clear();
      Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
      string text = "";

      do
      {
        text += Console.ReadLine();
        text += Environment.NewLine;
      }
      while (Console.ReadKey().Key != ConsoleKey.Escape);

      Salvar(text);
    }

    static void Salvar(string text)
    {
      Console.Clear();
      Console.WriteLine("Qual o caminho para salvar o arquivo? ");
      var caminho = Console.ReadLine();

      using (var arquivo = new StreamWriter(caminho))
      {
        arquivo.Write(text);
      }

      Console.WriteLine($"Arquivo salvo com sucesso no caminho: {caminho}");
      Menu();
    }
  }
}
