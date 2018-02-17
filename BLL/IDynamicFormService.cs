using System.Collections.Generic;
using System.Threading.Tasks;

using Domain.Models;

namespace BLL
{
    public interface IDynamicFormService
    {
        Task<List<Form>> GetAllForms();
        Task<Form> GetTopmostForm();

        Task UpdateForm(Form form);
    }
}
