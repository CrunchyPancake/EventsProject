using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace events.tac.local.Models.Base
{
    [SitecoreType(AutoMap = true)]
    public interface IGlassBase
    {
        
        Guid Id { get; set; }
        Guid TemplateId { get; set; }
        string Name { get; set; }
        string Url { get; }
        string FullPath { get; }
    }
}
