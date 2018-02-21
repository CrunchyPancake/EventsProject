using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using events.tac.local.Models.Base;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace events.tac.local.Models
{
    [SitecoreType(TemplateId = "{AB86861A-6030-46C5-B394-E8F99E8B87DB}", AutoMap = true)]
    public interface IEventDetail : IGlassBase, IContentBase
    {
        [SitecoreField("{D9873591-A605-4D0D-AEF3-5DA07F1BF91B}")]
        string HighLights { get; set; }

        [SitecoreField("{E2825C16-B4D0-4C14-9F7F-5B5AFFEB0627}")]
        Image EventImage { get; set; }
    }
}