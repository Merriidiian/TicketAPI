using System.Collections;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Tickets_API.Filters;

public class ticket_numberFilter : Attribute, IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        IDictionary<string, object?> Ticket = context.ActionArguments;
        foreach (var http in Ticket)
        {
         Console.WriteLine("{0},{1}", Ticket.Keys, Ticket.Values);   
        }
        //int ticket_numberLength = string.Join(", ", Ticket.Select<>(res => res.Key + )
        //int ticket_numberLength = string.Join()
        //Проверка длины билета
        /*if (ticket_numberLength != 13)
        {
            context.Result = new BadRequestResult();
        }*/
        //Проверка пола
        if (context.HttpContext.Request.Form["gender"] != "M" || context.HttpContext.Request.Form["gender"] != "F")
        {
            context.Result = new BadRequestResult();
        }

        if (context.HttpContext.Request.Form["doc_type"] == "00")
        {
            if (context.HttpContext.Request.Form["doc_number"].Count != 10)
            {
                context.Result = new BadRequestResult();
            }
        }
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        
    }
}