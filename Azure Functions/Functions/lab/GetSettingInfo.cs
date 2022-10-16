using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;

namespace lab
{
    public static class GetSettingInfo
    {
        [FunctionName("GetSettingInfo")]
        public static IActionResult Run(
            [HttpTrigger(methods: "GET")] HttpRequest request,
            [Blob("content/settings.json")] string json)
        {
            return new OkObjectResult(json);
        }
    }
}
