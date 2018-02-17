﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Domain.Models;
using BLL;
using AutoMapper;
using DynamicFormWeb.ViewModels;

namespace DynamicFormWeb.Controllers
{
    public class FormsController : Controller
    {
        private readonly IDynamicFormService dynamicFormService;

        public FormsController(IDynamicFormService dynamicFormService)
        {
            this.dynamicFormService = dynamicFormService;
        }
        
        public async Task<IActionResult> Index()
        {
            var topmostForm = await dynamicFormService.GetTopmostForm();

            var formViewModel = Mapper.Map<FormViewModel>(topmostForm);

            return View(formViewModel);
        }

        //// GET: Forms/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var form = await _context.Forms
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    if (form == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(form);
        //}

        //// GET: Forms/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Forms/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Name,Id")] Form form)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(form);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(form);
        //}

        //// GET: Forms/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var form = await _context.Forms.SingleOrDefaultAsync(m => m.Id == id);
        //    if (form == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(form);
        //}

        //// POST: Forms/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Name,Id")] Form form)
        //{
        //    if (id != form.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(form);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!FormExists(form.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(form);
        //}

        //// GET: Forms/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var form = await _context.Forms
        //        .SingleOrDefaultAsync(m => m.Id == id);
        //    if (form == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(form);
        //}

        //// POST: Forms/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var form = await _context.Forms.SingleOrDefaultAsync(m => m.Id == id);
        //    _context.Forms.Remove(form);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool FormExists(int id)
        //{
        //    return _context.Forms.Any(e => e.Id == id);
        //}
    }
}
