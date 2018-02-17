using System.Collections.Generic;

namespace DynamicFormWeb.ViewModels
{
    public class PropertyViewModel
    {
        public string Name { get; set; }
        public PropertyTypeViewModel Type { get; set; }
        public List<PropertyValueViewModel> Values { get; set; }
    }
}
