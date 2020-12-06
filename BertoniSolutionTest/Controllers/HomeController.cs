using BertoniSolutionTest.Models;
using BertoniSolutionTest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BertoniSolutionTest.Controllers
{
    public class HomeController : Controller
    {
        TestService _service = new TestService();
        public ActionResult Index()
        {
            var model = new AlbumViewModel();
            model.Albums = _service.GetAlbums().ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult GetPhotos(int albumId)
        {
            var model = new AlbumViewModel();
            model.Albums = _service.GetAlbums().ToList();
            model.Photos = _service.GetPhotosByAlbum(albumId).ToList();
            return View("Index", model);
        }




        [HttpPost]
        public ActionResult GetComments(int photoID)
        {
            var model = _service.GetCommentsByPhoto(photoID);
            return PartialView("_Comments", model);
        }
    }
}