using System.Collections.Generic;

namespace DynamicFormWeb.ViewModels
{
    public class FormViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PropertyViewModel> Properties { get; set; }
    }
}
