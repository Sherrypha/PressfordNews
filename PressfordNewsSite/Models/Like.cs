//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PressfordNewsSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Like
    {
        public string UserID { get; set; }
        public int ArticleID { get; set; }
        public int LikeId { get; set; }
    
        public virtual Article Article { get; set; }
        public virtual User User { get; set; }
    }
}
