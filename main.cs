using System;
using MCT;

class Program {
  public static void Main (string[] args) {
	  MorseCodeTranslator mct = new MorseCodeTranslator();

	  Console.Write("Text to Morse > ");
	  
	  string x = mct.TextToMorse(Console.ReadLine());
	  Console.WriteLine(x);
  }
}
