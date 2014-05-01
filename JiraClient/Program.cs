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
            foreach (string current in sources)
            {
                Issue issue = GetJiraIssue(current);
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

        private static Issue GetJiraIssue(string key)
        {
            WebClient client = new WebClient();

            // create credentials, base64 encode of username:password
            string user = ConfigurationManager.AppSettings["user"];
            string passwd = ConfigurationManager.AppSettings["pwd"];
            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", user, passwd)));
            // Inject this string as the Authorization header
            client.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", credentials);

            string baseUrl = ConfigurationManager.AppSettings["baseurl"];
            string url = string.Format("{0}/issue/{1}", baseUrl, key);

            var jsonResponse = client.DownloadString(url);
            Issue issue = JsonConvert.DeserializeObject<Issue>(jsonResponse);
            return issue;

        }
    }
}
