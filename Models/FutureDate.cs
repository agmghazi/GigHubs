using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.Models
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var tryDate = DateTime.TryParseExact(Convert.ToString(value),
                "d MMM yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out var dateTime);
            return (tryDate && dateTime > DateTime.Now);
        }
    }
}
