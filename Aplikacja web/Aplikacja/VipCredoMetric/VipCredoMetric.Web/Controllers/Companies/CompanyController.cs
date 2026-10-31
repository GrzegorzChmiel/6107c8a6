using Microsoft.AspNetCore.Mvc;
using VipCredoMetric.Application.Interfaces;
using VipCredoMetric.Web.Models.Companies;

namespace VipCredoMetric.Web.Controllers.Companies;

public class CompanyController(ISampleDataStore dataStore) : Controller
{
   [HttpGet("Companies")]
   public IActionResult GetCompaniesList()
   {
      var model = dataStore.Companies.ToListItemViewModels();
      return View("~/Views/Companies/CompaniesList.cshtml", model);
   }
}
