using System.Collections.Generic;

namespace DynamicFormWeb.ViewModels
{
    public class PropertyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PropertyTypeViewModel Type { get; set; }
        public List<PropertyValueViewModel> Values { get; set; }
        public PropertyValueViewModel CurrentValue { get; set; }
    }
}
