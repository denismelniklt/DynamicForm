using System.Collections.Generic;

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
