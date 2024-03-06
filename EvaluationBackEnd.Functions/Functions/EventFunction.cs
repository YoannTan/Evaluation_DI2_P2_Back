using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace EvaluationBackEnd.Functions.Functions;

public class EventFunction
{
    [Function("events")]
    public async Task<HttpResponseData> Events([HttpTrigger(AuthorizationLevel.Function, "get", Route = "events")] HttpRequestData req)
    {
        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
        await response.WriteStringAsync("Hello World");

        return response;
    }
}