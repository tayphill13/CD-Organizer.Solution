using Microsoft.AspNetCore.Mvc;

namespace CdOrganizer.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet("/albumcoverart_photos")]
    public ActionResult AlbumCoverArtPhotos()
    {
      return View();
    }
  }
}