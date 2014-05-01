using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraUtils.Entities
{
    /// <summary>
    /// Representation of the fields of an issue
    /// </summary>
    public class Fields
    {
        public string Summary { get; set; }
        public string Description { get; set; }
    }
}
