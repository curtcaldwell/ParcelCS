using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Parcels()
    {
      ParcelVariable newParcelVariable = new ParcelVariable();
      newParcelVariable.SetWidth(int.Parse(Request.Query["parcel-width"]));
      newParcelVariable.SetLength(int.Parse(Request.Query["parcel-length"]));
      newParcelVariable.SetHeight(int.Parse(Request.Query["parcel-height"]));
      //newParcelVariable.GetVolume(int.Parse(Request.Query["parcel-height"]));
      return View(newParcelVariable);
    }
  }
}
