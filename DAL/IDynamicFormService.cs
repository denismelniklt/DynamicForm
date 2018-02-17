using System.Collections.Generic;
using System.Threading.Tasks;

using Domain.Models;

namespace DAL
{
    public interface IDynamicFormService
    {
        Task<List<Form>> GetAllForms();

        Task UpdateForm(Form form);
    }
}