using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraUtils.Entities
{
    /// <summary>
    /// Representation of a jira project
    /// </summary>
    public class Project
    {
        public int Id { get; set; }
        public string Self { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string Description { get; set; }
    }
}
