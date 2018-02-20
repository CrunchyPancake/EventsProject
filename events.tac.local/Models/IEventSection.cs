using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using events.tac.local.Models.Base;

namespace events.tac.local.Models
{
    public interface IEventSection : IGlassBase
    {
        IEnumerable<IEventDetailsList> Children { get; set; }
    }
}