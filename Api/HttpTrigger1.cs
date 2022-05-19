using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Options;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Api
{
    public class HttpTrigger1
    {
        [FunctionName("Test")]
        public IActionResult Logout([HttpTrigger(AuthorizationLevel.Function, "get", Route = "test")] HttpRequest request)
        {
            return new OkResult();
        }
    }
}
