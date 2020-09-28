using System;
using System.Collections.Generic;
using System.Text;

namespace GeboortedatumApp
{
	class AgeCalculation
	{
		private DateTime now;

		public AgeCalculation()
		{
			now = DateTime.Today;
		}

		public int BerekenLeeftijd(DateTime geboorteDatum)
		{
			return now.Year - geboorteDatum.Year;
		}
	}
}
