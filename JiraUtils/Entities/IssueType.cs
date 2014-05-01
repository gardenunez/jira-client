using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraUtils.Entities
{
    /// <summary>
    /// Representation of a jira issue type
    /// </summary>
    public class IssueType
    {
        public int Id { get; set; }
        public string Self { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }

    }
}
