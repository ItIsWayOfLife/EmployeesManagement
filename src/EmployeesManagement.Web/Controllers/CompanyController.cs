﻿using EmployeesManagement.Core.Exceptions;
using EmployeesManagement.Core.Interfaces.IServices;
using EmployeesManagement.Web.Interfaces.IViewConverters;
using EmployeesManagement.Web.Models.Company;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace EmployeesManagement.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;
        private readonly ILegalFormService _legalFormService;
        private readonly IActivityService _activityService;
        private readonly ICompanyViewConverter _companyViewConverter;

        public CompanyController(ICompanyService companyService,
            ILegalFormService legalFormService,
            IActivityService activityService,
            ICompanyViewConverter companyViewConverter)
        {
            _companyService = companyService;
            _legalFormService = legalFormService;
            _activityService = activityService;
            _companyViewConverter = companyViewConverter;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var companiesDTOs = _companyService.GetAll();

            var companiesViews = _companyViewConverter.ConvertModelsToViewModels(companiesDTOs);

            return View(companiesViews);
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
                    var companyDTO = _companyViewConverter.ConvertAddViewModelToModel(model.AddCompanyViewModel);

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

            return View(new EditCompanySelectListViewModel()
            {
                EditCompanyViewModel = _companyViewConverter.ConvertModelToEditViewModel(companyDTO),
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
                    var companyDTO = _companyViewConverter.ConvertEditViewModelToModel(model.EditCompanyViewModel);

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
            try
            {
                _companyService.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { requestId = "500", errorInfo = string.Empty });
            }
        }
    }
}
