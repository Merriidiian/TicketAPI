using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Tickets_API.Filters.ModelValidation;

public class ticket_numberValidation : ValidationAttribute
{
    public override bool IsValid (object value)
    {
        if (value.ToString().Length != 13)
        {
            throw new BadHttpRequestException("400");
        }
        return true;
    }
}