using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace lab
{
    public static class Echo
    {
        [FunctionName("Echo")]
        public static IActionResult Run(
            [HttpTrigger(methods:"POST")]HttpRequest request,
            ILogger logger)
        {
            logger.LogInformation("Received a request");




            return new OkObjectResult(request.Body);
        }
    }
}
