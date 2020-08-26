using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mamachachas.Models
{
	public interface IPieRepository
	{
		IEnumerable<Bread> AllBread { get; }
		IEnumerable<Bread> BreadOfTheWeek { get; }
		Bread GetBreadById(int breadId);
	}
}
