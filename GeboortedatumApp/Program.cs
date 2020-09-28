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

			//Run het programma:
			DateTime geboortedatum = input.VraagVoorDatum();
			int leeftijd = ageCalculation.BerekenLeeftijd(geboortedatum);

			//laat de leeftijd zien:

			//vraag aan de gebruiker of hij wilt stoppen of doorgaan:
		}
	}
}
