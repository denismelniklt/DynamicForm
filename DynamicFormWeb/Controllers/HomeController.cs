using AutoMapper;
using BLL;
using Domain.Models;
using DynamicFormWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DynamicFormWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDynamicFormService dynamicFormService;

        public HomeController(IDynamicFormService dynamicFormService)
        {
            this.dynamicFormService = dynamicFormService;
        }

        public async Task<IActionResult> Index()
        {
            var topmostForm = await dynamicFormService.GetTopmostForm();

            FormViewModel formViewModel;

            if (topmostForm == null)
            {
                formViewModel = new FormViewModel();
            }
            else
            {
                formViewModel = Mapper.Map<FormViewModel>(topmostForm);
            }

            return View(formViewModel);
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update(Form form)
        {
            await dynamicFormService.UpdateForm(form);

            return RedirectToAction(nameof(Index));
        }

    }
}
