using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Domain.Models
{
    public class Property : Base
    {
        public string Name { get; set; }
        public PropertyType Type { get; set; }
        public PropertyValue CurrentValue { get; set; }
        public List<PropertyValue> Values { get; set; }

        public Property()
        {
            Values = new List<PropertyValue>();
        }
    }
}
