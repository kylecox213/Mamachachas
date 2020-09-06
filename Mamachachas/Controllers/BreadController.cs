using Mamachachas.Models;
using Mamachachas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mamachachas.Controllers
{
	public class BreadController : Controller
	{
		private readonly IBreadRepository _breadRepository;
		private readonly ICategoryRepository _categoryRepository;

		public BreadController(IBreadRepository breadRepository, ICategoryRepository categoryRepository)
		{
			_breadRepository = breadRepository;
			_categoryRepository = categoryRepository;
		}

		public IActionResult List()
		{
			// ViewBag.CurrentCategory = "";

			// return View(_breadRepository.AllBread);
			BreadListViewModel breadListViewModel = new BreadListViewModel();
			breadListViewModel.Bread = _breadRepository.AllBread;

			breadListViewModel.CurrentCategory = "";
			return View(breadListViewModel);
		}
	}
}
