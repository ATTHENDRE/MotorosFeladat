using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorosFeladat
{
	internal class Motor
	{
		string brand;
		string name;
		int releaseYear;
		double performance;
		double pricelnEur;

		public string Brand { get => brand; set => brand = value; }
		public string Name { get => name; set => name = value; }
		public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
		public double Performance { get => performance; set => performance = value; }
		public double PricelnEur { get => pricelnEur; set => pricelnEur = value; }
	}
}
