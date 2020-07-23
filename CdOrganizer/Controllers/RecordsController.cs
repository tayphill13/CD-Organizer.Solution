using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
  public class RecordsController : Controller
  {

    [HttpGet("/records")]
    public ActionResult Index()
    {
      List<Record> allRecords = Record.GetAll();
      return View(allRecords);
    }

    [HttpGet("/records/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/records")]
    public ActionResult Create(string recordName)
    {
      Record newRecord = new Record(recordName);
      return RedirectToAction("Index");
    }

    [HttpGet("/records/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Record selectedRecord = Record.Find(id);
      List<Song> recordSongs = selectedRecord.Songs;
      model.Add("record", selectedRecord);
      model.Add("songs", recordSongs);
      return View(model);
    }

    // This one creates new Songs within a given Record, not new Records:
    [HttpPost("/records/{recordId}/songs")]
    public ActionResult Create(int recordId, string songDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Record foundRecord = Record.Find(recordId);
      Song newSong = new Song(songDescription);
      foundRecord.AddSong(newSong);
      List<Song> recordSongs = foundRecord.Songs;
      model.Add("songs", recordSongs);
      model.Add("record", foundRecord);
      return View("Show", model);
    }

  }
}