using Microsoft.AspNetCore.Mvc;
using VipCredoMetric.Application.Interfaces;
using VipCredoMetric.Web.Models.Addresses;

namespace VipCredoMetric.Web.Controllers.Addresses;

public class AddressController(ISampleDataStore dataStore) : Controller
{
   [HttpGet("Addresses/{id:guid}")]
   public IActionResult GetAddressDetails(Guid id)
   {
      var address = dataStore.Addresses.FirstOrDefault(a => a.Id == id);
      if (address is null)
      {
         return NotFound();
      }

      var model = address.ToFormViewModel();
      return View("~/Views/Addresses/AddressDetails.cshtml", model);
   }
}
