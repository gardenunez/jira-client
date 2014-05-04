using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JiraUtils.Entities
{
    public class Author
    {
        public string Self { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string DisplayName { get; set; }
        public bool Active { get; set; }
    }
}
