using System;

namespace GeboortedatumApp
{
	class Program
	{ 
		static void Main(string[] args)
		{
			//Maak objecten hier:
			Input input = new Input();

			//Hier komt het welkomst-bericht

			//Tijdelijke test-code:
			DateTime geboortedatum = input.VraagVoorDatum();

			Console.WriteLine(geboortedatum.ToString());
		}
	}
}
