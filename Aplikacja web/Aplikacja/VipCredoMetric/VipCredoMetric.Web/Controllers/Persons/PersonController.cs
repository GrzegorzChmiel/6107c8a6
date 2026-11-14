using Microsoft.AspNetCore.Mvc;
using VipCredoMetric.Application.Interfaces;
using VipCredoMetric.Web.Models.Common;
using VipCredoMetric.Web.Models.Persons;

namespace VipCredoMetric.Web.Controllers.Persons;

public class PersonController(ISampleDataStore dataStore) : Controller
{
   private const int PageSize = 10;

   [HttpGet("Persons")]
   public IActionResult GetPersonsList(int page = 1)
   {
      var allItems = dataStore.Persons.ToListItemViewModels().ToList();
      var model = PagedListViewModel<PersonListItemViewModel>.Create(allItems, page, PageSize);
      return View("~/Views/Persons/PersonsList.cshtml", model);
   }

   [HttpGet("Persons/{id:guid}")]
   public IActionResult GetPersonDetails(Guid id)
   {
      var person = dataStore.Persons.FirstOrDefault(p => p.Id == id);
      if (person is null)
      {
         return NotFound();
      }

      var model = person.ToFormViewModel();
      return View("~/Views/Persons/PersonDetails.cshtml", model);
   }
}
