// using Microsoft.AspNetCore.Mvc.Filters;
// using Microsoft.Extensions.Primitives;
// using Newtonsoft.Json.Linq;
// using Newtonsoft.Json.Schema;
// using Tickets_API;
//
// namespace Tickets_API.Filters;
//
// public class SaleJsonFilters: Attribute, IActionFilter
// {
//     public void OnActionExecuting(ActionExecutingContext context)
//     {
//         string jsonSchema = File.ReadAllText("Json/saleSchema.json");
//         JSchema schema = JSchema.Parse(jsonSchema);
//         //var jsonContent = context.ActionArguments();
//        // JObject jObject = JObject.Parse(jsonContent.ToString());
//         //jObject.IsValid(schema, out IList<string> messages);
//         foreach (var item in messages)
//         {
//          //   Console.WriteLine(item);
//         }
//     }
//
//     public void OnActionExecuted(ActionExecutedContext context)
//     {
//     }
// }

