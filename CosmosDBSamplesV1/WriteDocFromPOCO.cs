using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace CosmosDBSamplesV1
{
    public static class WriteDocFromPOCO
    {
        [FunctionName("WriteDocFromPOCO")]
        public static void Run(
            [QueueTrigger("todoqueueforwrite")] ToDoItem toDoItem,
            [DocumentDB("ToDoItems","Items", 
                ConnectionStringSetting = "CosmosDBConnection")]out dynamic document,
            TraceWriter log)
        {
            log.Info($"C# Queue trigger function processed Id={toDoItem?.Id}, Description={toDoItem.Description}");

            document = toDoItem;
        }
    }
}
