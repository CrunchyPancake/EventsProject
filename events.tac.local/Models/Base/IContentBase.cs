using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace events.tac.local.Models.Base
{
    [SitecoreType(TemplateId = "{AB86861A-6030-46C5-B394-E8F99E8B87DB}", AutoMap = true)]
    public interface IContentBase
    {
        
        [SitecoreField("{5A24E965-8B50-4154-AA98-157687DEE85D}")]
        string ContentHeading { get; set; }

        [SitecoreField("{E3621199-BEB5-4241-B9C1-AC85596EBCA1}")]
        string ContentIntro { get; set; }
    }
}