using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BertoniSolutionTest.Models
{
    public class CommentModel
    {
        public int postId { get; set; }
        public int Id { get; set; }
        public string name { get; set; }
        public string email{ get; set; }
        public string body { get; set; }

        public PhotoModel PhotoModel { get; set; }
    }
}