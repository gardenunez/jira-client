using JiraUtils.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JiraClient
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sources = new List<string>() { "TES-1", "TES-2", "TES-3" };
            string user = ConfigurationManager.AppSettings[Constants.USER_KEY];
            string passwd = ConfigurationManager.AppSettings[Constants.PASS_KEY];
            string baseUrl = ConfigurationManager.AppSettings[Constants.BASEURL_KEY];

            foreach (string current in sources)
            {
                Issue issue = JiraUtils.JiraMiscUtils.GetJiraIssueByKey(baseUrl, current, user, passwd);
                Console.WriteLine("ID: {0}  KEY: {1}", issue.Id, issue.Key);
                Console.WriteLine("Description: {0}",issue.Fields.Description);
                Console.WriteLine("Created: {0}", issue.Fields.Created);
                Console.WriteLine("Updated: {0}", issue.Fields.Updated);
                Console.WriteLine("DueDate: {0}", issue.Fields.DueDate);
                Console.WriteLine("LastViewed: {0}", issue.Fields.LastViewed);
                Console.WriteLine("Type: {0}", issue.Fields.IssueType.Name);
                Console.WriteLine("Project: {0}", issue.Fields.Project.Name);
                Console.WriteLine("*********************************");
            }
            Console.Read();
        }

      
    }
}
