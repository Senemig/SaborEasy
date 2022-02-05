using System;
using System.IO;

namespace Sabor_Easy_MVC.Models
{
    public class Post
    {
        public int postId {get; set;}
        public string titulo { get; set; }
        public string hashtags { get; set; }
        public string descricao { get; set; }
        public string imagePath { get; set; }
        public DateTime postDate { get; set; }
    }
}