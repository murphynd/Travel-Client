using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelClient.Models;

namespace TravelClient.Controllers
{
  public class PlacesController : Controller
  {
    public IActionResult Index()
    {
      var allPlaces = Place.GetPlaces();
      return View(allPlaces);
    }
  }
}