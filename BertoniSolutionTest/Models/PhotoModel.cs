using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BertoniSolutionTest.Models
{
    public class PhotoModel
    {
        public int albumId { get; set; }
        public int Id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }

        public List<CommentModel> Comments{ get; set; }

    }
}