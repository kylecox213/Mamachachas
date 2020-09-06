using Mamachachas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mamachachas.ViewModels
{
	public class BreadListViewModel
	{
		public IEnumerable<Bread> Bread { get; set; }
		public string CurrentCategory { get; set; }
	}
}
