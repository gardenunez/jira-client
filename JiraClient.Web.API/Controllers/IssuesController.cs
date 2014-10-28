using JiraUtils;
using JiraUtils.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JiraClient.Web.API.Controllers
{
    public class IssuesController : ApiController
    {
        private string _serverUrl;
        public IssuesController()
        {
            this._serverUrl = ConfigurationManager.AppSettings[Constants.SERVER_URL];

        }

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetIssueByKey(string id)
        {
            JiraService service = new JiraService(this._serverUrl);
            Issue issue = service.GetJiraIssueByIdOrKey(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, issue, "application/json");
            return response;
        }

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetIssuesBySprint(string sprint)
        {
            JiraService service = new JiraService(this._serverUrl);
            IEnumerable<Issue> issues = service.GetIssuesBySprint(sprint);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, issues, "application/json");
            return response;
        }

    }
}
