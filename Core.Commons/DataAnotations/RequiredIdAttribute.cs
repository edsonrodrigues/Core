using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace Core.Commons
{
    public class RequiredIdAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                return (int)value > 0;
            }

            return base.IsValid(value);
        }
    }
}
