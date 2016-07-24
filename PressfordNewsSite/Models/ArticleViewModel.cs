using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PressfordNewsSite.Models
{
    public class ArticleViewModel
    {
        //reference to models needed for the article views
        public IEnumerable<Article> ArticleModel { get; set; }
        public IEnumerable<Like> LikeModel { get; set; }

    }
}