using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InAndOut.Controllers
{
	public class ExpenseTypeController : Controller
	{

		private readonly ApplicationDBContext _db;

		public ExpenseTypeController(ApplicationDBContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			IEnumerable<ExpenseType> objList = _db.ExpenseTypes;

			return View(objList);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(ExpenseType obj)
		{
			if (ModelState.IsValid)
			{
				_db.ExpenseTypes.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(obj);
		}

		public IActionResult Update(int? id)
		{

			if (id == null || id == 0)
			{
				return NotFound();
			}

			var obj = _db.ExpenseTypes.Find(id);

			if (obj == null)
			{
				return NotFound();
			}

			return View(obj);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Update(ExpenseType obj)
		{
			if (ModelState.IsValid)
			{
				_db.ExpenseTypes.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(obj);
		}

		public IActionResult Delete(int? id)
		{
			
			if(id == null || id == 0)
			{
				return NotFound();
			}

			var obj = _db.ExpenseTypes.Find(id);

			if(obj == null)
			{
				return NotFound();
			}

			return View(obj);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeletePost(int? id)
		{
			var obj = _db.ExpenseTypes.Find(id);

			if (obj == null)
			{
				return NotFound();
			}

			_db.ExpenseTypes.Remove(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}
