using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Travel.Models;

namespace Travel.Controllers 
{
  public class DestinationsController : Controller 
  {
    public IActionResult Index()
    {
      var allDestinations = Destination.GetDestinations();
      return View(allDestinations);
    }

    [HttpPost]
    public IActionResult Index(Destination destination)
    {
      Destination.Post(destination);
      return RedirectToAction("Index"); 
    }

    public IActionResult Details(int id)
    {
      var destination = Destination.GetDetails(id);
      return View(destination);
    }

    public IActionResult Edit(int id)
    {
      return View();
    }
  }
}