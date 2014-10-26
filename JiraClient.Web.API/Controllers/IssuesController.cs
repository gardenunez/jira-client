using JiraUtils;
using JiraUtils.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JiraClient.Web.API.Controllers
{
    public class IssuesController : ApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage GetIssueByKey(string id)
        {
            string serverUrl = "http://jira.atlassian.com/rest/api/2";
            JiraService service = new JiraService(serverUrl);
            Issue issue = service.GetJiraIssueByIdOrKey(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, issue, "application/json");
            return response;
        }
    }
}
