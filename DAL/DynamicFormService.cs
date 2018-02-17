using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Domain;
using System.Linq;

namespace DAL
{
    public class DynamicFormService : IDynamicFormService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public DynamicFormService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<List<Form>> GetAllForms()
        {
            return await applicationDbContext.Forms
                .Include(f => f.Properties)
                .Include("Properties.Values")
                .Include("Properties.Type")
                .ToListAsync();
        }

        public async Task UpdateForm(Form form)
        {
            var formToUpdate = await applicationDbContext.Forms
                .Where(f => f.Id == form.Id)
                .FirstOrDefaultAsync();

            formToUpdate = form;

            await applicationDbContext.SaveChangesAsync();
        } 
    }
}
