using System;
using System.Collections.Generic;
using System.Text;

namespace GeboortedatumApp
{
	class Input
	{
		private DateTime date;

		public DateTime VraagVoorDatum()
		{
			Console.WriteLine("Voeg je geboorte dag in (bv: 5): ");
			int dag = Int32.Parse(Console.ReadLine());

			Console.WriteLine("Voeg je geboorte maand in (bv: 6): ");
			int maand = Int32.Parse(Console.ReadLine());

			Console.WriteLine("Voeg je geboorte jaar in (bv: 1992): ");
			int jaar = Int32.Parse(Console.ReadLine());

			date.AddDays(dag);
			date.AddMonths(maand);
			date.AddYears(jaar);

			return date;
		}
	}
}
