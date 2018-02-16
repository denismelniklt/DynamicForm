using System.Collections.Generic;

namespace Domain.Models
{
    public class Property : Base
    {
        public PropertyType Type { get; set; }
        public PropertyName Name { get; set; }
        public List<PropertyValue> Values { get; set; }

        public Property()
        {
            Values = new List<PropertyValue>();
        }
    }
}
