using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;
using System.Collections.Generic;

namespace CdOrganizer.Controllers
{
  public class SongsController : Controller
  {

    [HttpGet("/records/{recordId}/songs/new")]
    public ActionResult New(int recordId)
    {
      Record record = Record.Find(RecordId);
      return View(record);
    }

    [HttpGet("/records/{recordId}/songs/{songId}")]
    public ActionResult Show(int recordId, int songId)
    {
      Song song = Song.Find(song);
      Record record = Record.Find(recordId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("song", song);
      model.Add("record", record);
      return View(model);
    }

    [HttpPost("/songs/delete")]
    public ActionResult DeleteAll()
    {
      Song.ClearAll();
      return View();
    }
  }
}