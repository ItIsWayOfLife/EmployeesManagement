﻿using EmployeesManagement.Core.DTOs;
using EmployeesManagement.Core.Exceptions;
using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Models.Company;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagement.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly ILegalFormService _legalFormService;
        private readonly IActivityService _activityService;

        public CompanyController(ICompanyService companyService,
            ILegalFormService legalFormService,
            IActivityService activityService)
        {
            _companyService = companyService;
            _legalFormService = legalFormService;
            _activityService = activityService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var models = _companyService.GetAll();

            var companyViewModels = new List<CompanyViewModel>();

            foreach (var model in models)
            {
                companyViewModels.Add(new CompanyViewModel()
                {
                    Id = model.Id,
                    Name = model.Name,
                    ActivityName = model.ActivityName,
                    LegalFormName = model.LegalFormName,
                    Size = model.Size
                });
            }

            return View(companyViewModels);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new AddCompanySelectListViewModel()
            {
                LegalForms = new SelectList(_legalFormService.GetAllName()),
                Activities = new SelectList(_activityService.GetAllName())
            });
        }

        [HttpPost]
        public IActionResult Add(AddCompanySelectListViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var companyDTO =new CompanyDTO() 
                    {
                     ActivityName = model.AddCompanyViewModel.ActivityName,
                      LegalFormName = model.AddCompanyViewModel.LegalFormName,
                       Name = model.AddCompanyViewModel.Name
                    };

                    _companyService.Add(companyDTO);


                    return RedirectToAction(nameof(Index));
                }
                catch (ValidationException ex)
                {
                    ModelState.AddModelError(ex.Property, ex.Message);
                }
            }

            model.LegalForms = new SelectList(_legalFormService.GetAllName());
            model.Activities = new SelectList(_activityService.GetAllName());

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var companyDTO = _companyService.Get(id);

            if (companyDTO == null)
            {
                return RedirectToAction("Error", "Home", new { requestId = "400", errorInfo = "Компания не найдена" });
            }

            var editCompanyViewModel = new EditCompanyViewModel()
            { 
             Id = companyDTO.Id,
              ActivityName = companyDTO.ActivityName,
               LegalFormName = companyDTO.LegalFormName,
                Name = companyDTO.Name
            };

            return View(new EditCompanySelectListViewModel()
            {
                EditCompanyViewModel = editCompanyViewModel,
                LegalForms = new SelectList(_legalFormService.GetAllName()),
                Activities = new SelectList(_activityService.GetAllName())
            });
        }

        [HttpPost]
        public IActionResult Edit(EditCompanySelectListViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var companyDTO = new CompanyDTO() 
                    {
                     Id = model.EditCompanyViewModel.Id,
                      ActivityName = model.EditCompanyViewModel.ActivityName,
                       LegalFormName = model.EditCompanyViewModel.LegalFormName,
                        Name = model.EditCompanyViewModel.Name
                    };

                    _companyService.Edit(companyDTO);

                    return RedirectToAction(nameof(Index));
                }
                catch (ValidationException ex)
                {
                    ModelState.AddModelError(ex.Property, ex.Message);
                }
            }

            model.LegalForms = new SelectList(_legalFormService.GetAllName());
            model.Activities = new SelectList(_activityService.GetAllName());

            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
           
                _companyService.Delete(id);

                return RedirectToAction(nameof(Index));
           
        }
    }
}