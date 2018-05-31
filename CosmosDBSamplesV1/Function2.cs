// This is the default URL for triggering event grid function in the local environment.
// http://localhost:7071/admin/extensions/EventGridExtensionConfig?functionName={functionname} 

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CosmosDBSamplesV1
{
    public static class Function2
    {
        [FunctionName("Function2")]
        public static void Run([EventGridTrigger] Microsoft.Azure.EventGrid.Models.EventGridEvent eventGridEvent, TraceWriter log)
        {
            log.Info(eventGridEvent.Data.ToString());
        }
    }
}
