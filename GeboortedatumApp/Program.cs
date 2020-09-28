using System;

namespace GeboortedatumApp
{
	class Program
	{ 
		static void Main(string[] args)
		{
			//Maak objecten hier:
			Input input = new Input();


			welcom welcome = new welcom();

			//Tijdelijke test-code:
			DateTime geboortedatum = input.VraagVoorDatum();

			Console.WriteLine(geboortedatum.ToString());
		}
	}
}
