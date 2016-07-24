using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PressfordNewsSite.Models
{
    public class InterestCalculator
    {
        private PressfordNewsData db = new PressfordNewsData();
        public int CountLikes(int ArticleID)
         {
            var likes = db.Likes;
            return likes.Count(l => l.ArticleID == ArticleID);
        }
    }
}