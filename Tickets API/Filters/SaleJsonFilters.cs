using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Tickets_API;

namespace Tickets_API.Filters;

public class SaleJsonFilters: Attribute, IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        JSchema saleSchema = JSchema.Parse(File.ReadAllText("saleSchema.json"));
        JObject jsonCheck = JObject.Parse(context.ToString());
        jsonCheck.IsValid(saleSchema, out IList<string> messages);
        foreach (var item in messages)
        {
            Console.WriteLine(item);
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
    }
}