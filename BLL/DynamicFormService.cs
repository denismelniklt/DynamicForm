using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using Domain.Models;

using IDynamicFormServiceDAL = DAL.IDynamicFormService;

namespace BLL
{
    public class DynamicFormService : IDynamicFormService
    {
        private const int TopmostDynamicFormTakeCount = 1;
        private IDynamicFormServiceDAL dynamicFormServiceDAL;

        public DynamicFormService(IDynamicFormServiceDAL dynamicFormServiceDAL)
        {
            this.dynamicFormServiceDAL = dynamicFormServiceDAL;
        }

        public async Task<List<Form>> GetAllForms()
        {
            return await dynamicFormServiceDAL.GetAllForms();
        }

        public async Task<Form> GetTopmostForm()
        {
            var formList = await dynamicFormServiceDAL.GetAllForms();
            var topmostForm = formList.FirstOrDefault();

            return topmostForm;
        }

        public async Task UpdateForm(Form form)
        {
            await dynamicFormServiceDAL.UpdateForm(form);
        }
    }
}
