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
    [HttpGet("/todolist_photos")]
    public ActionResult ToDoListPhotos()
    {
      return View();
    }
  }
}