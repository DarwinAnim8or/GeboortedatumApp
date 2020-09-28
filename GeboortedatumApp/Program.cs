using System;

namespace GeboortedatumApp
{
	class Program
	{ 
		static void Main(string[] args)
		{
			//Maak objecten hier:
			Input input = new Input();
			AgeCalculation ageCalculation = new AgeCalculation();

			welcom welcome = new welcom(); //geeft welkomst-bericht weer

			while (true) {
				//Run het programma:
				DateTime geboortedatum = input.VraagVoorDatum();
				int leeftijd = ageCalculation.BerekenLeeftijd(geboortedatum);

				Output output = new Output(leeftijd);
				Console.WriteLine("wil je blijven door gaan j/n");
				string doorgaan = Console.ReadLine();
				if (doorgaan == "n") 
				{
					break;
				}
			}
			
		}
	}
}
