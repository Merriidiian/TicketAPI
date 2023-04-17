using System.ComponentModel.DataAnnotations;

namespace Tickets_API.Filters.ModelValidation;

public class doc_typeValidation: ValidationAttribute
{
    public static int doc_type = 1;
    public override bool IsValid(object value)
    {
        
        if (value.ToString() == "00")
        {
            doc_type = 0;
        }

        return true;
    }
}