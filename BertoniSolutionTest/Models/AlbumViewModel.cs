using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BertoniSolutionTest.Models
{
    public class AlbumViewModel
    {

        public List<AlbumModel> Albums { get; set; }
        public int albumId { get; set; }
        public List<PhotoModel> Photos{ get; set; }

        public AlbumViewModel()
        {
            Albums = new List<AlbumModel>();
            Photos = new List<PhotoModel>();
        }
    }
}