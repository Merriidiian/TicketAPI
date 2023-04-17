using System.ComponentModel.DataAnnotations;

namespace Tickets_API.Filters.ModelValidation;

public class genderValidation : ValidationAttribute
{
    public override bool IsValid (object value)
    {
        if (value.ToString() != "M" && value.ToString() != "F" )
        {
            throw new BadHttpRequestException("400");
        }
        return true;
    }
}