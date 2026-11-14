using Microsoft.AspNetCore.Mvc;
using VipCredoMetric.Application.Interfaces;
using VipCredoMetric.Web.Models.Common;
using VipCredoMetric.Web.Models.Companies;

namespace VipCredoMetric.Web.Controllers.Companies;

public class CompanyController(ISampleDataStore dataStore) : Controller
{
   private const int PageSize = 10;

   [HttpGet("Companies")]
   public IActionResult GetCompaniesList(int page = 1)
   {
      var allItems = dataStore.Companies.ToListItemViewModels().ToList();
      var model = PagedListViewModel<CompanyListItemViewModel>.Create(allItems, page, PageSize);
      return View("~/Views/Companies/CompaniesList.cshtml", model);
   }

   [HttpGet("Companies/{id:guid}")]
   public IActionResult GetCompanyDetails(Guid id)
   {
      var company = dataStore.Companies.FirstOrDefault(c => c.Id == id);
      if (company is null)
      {
         return NotFound();
      }

      var model = company.ToFormViewModel();
      return View("~/Views/Companies/CompanyDetails.cshtml", model);
   }
}
