using System;
using System.Threading;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Escolha um modo: 1 - Modo Toque, 2 - Modo Constante, 3 - Modo Teclado");
    int modo = int.Parse(Console.ReadLine());

    switch (modo)
    {
    case 1: 
      ModoToque();
      break;
    case 2:
      ModoConstante();
      break;
    case 3: 
      ModoTeclado();
      break;
    default:
      Console.WriteLine("Modo Inválido.");
      break;
    }
  }

  static void ModoToque() 
  {
    Console.WriteLine("Modo Toque ativado. Pressione qualquer tecla para ouvir o bip.");
    while (true)
    {
      if (Console.KeyAvailable) {
        Console.Beep();
        Console.ReadKey(true);
      }
      Thread.Sleep(10);
    }
  }

      static void ModoConstante()
  {
    Console.WriteLine("Modo Constante ativado. Pressione Ctrl+C para encerrar.");
    while (true)
    {
      Console.Beep();
      Thread.Sleep(500);
    }
  }

  static void ModoTeclado()
  {
    Console.WriteLine("Modo Teclado ativado. Pressione qualquer tecla para ouvir o bip associado.");
      while (true) 
    {
      ConsoleKeyInfo keyInfo = Console.ReadKey(true);
      char keyChar = keyInfo.KeyChar;

      int frequencia = 800;

      if (char.IsLetter(keyChar))
      {
        if (keyChar >= 'Q' && keyChar <= 'P')
        {
          frequencia = 500 + (keyChar - 'Q') * 50;
        }
        else if (keyChar >= 'A' && keyChar <= 'M')
        {
          frequencia = 500 + (keyChar - 'A') * 200;
        }
      }
      Console.Beep(frequencia, 300);
    }
  }
}