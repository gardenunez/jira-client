using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraUtils.Entities
{
    public class Comment
    {
        public string Self { get; set; }
        public int Id { get; set; }
        public Author Author { get; set; }
        public string Body { get; set; }
        public Author UpdateAuthor { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
