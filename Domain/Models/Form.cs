using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Domain.Models
{
    public class Form : Base
    {
        public string Name { get; set; }
        public List<Property> Properties { get; set; }

        public Form()
        {
            Properties = new List<Property>();
        }
    }
}
