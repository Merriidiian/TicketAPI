using System.ComponentModel.DataAnnotations;
namespace Tickets_API.Filters.ModelValidation;

public class doc_numberValidation: ValidationAttribute
{
    
    public override bool IsValid (object value)
    {
        if (value.ToString().Length == 10 && doc_typeValidation.doc_type == 0)
        {
        }
        else
        {
            throw new BadHttpRequestException("400");
        }
        return true;
    }
}