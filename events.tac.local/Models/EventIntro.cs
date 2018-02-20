using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace events.tac.local.Models
{
    public class EventIntro
    {
        public virtual HtmlString ContentHeading { get; set;}
        public virtual HtmlString ContentIntro { get; set; }
        public virtual HtmlString ContentBody { get; set; }
        public virtual HtmlString EventImage { get; set; }
        public virtual HtmlString Highlights { get; set; }
        public virtual HtmlString StartDate { get; set; }
        public virtual HtmlString Duration { get; set; }
        public virtual HtmlString DifficultyLevel { get; set; }
    }
}