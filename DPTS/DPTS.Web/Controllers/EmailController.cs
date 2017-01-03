using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DPTS.Domain.Core;
using DPTS.Domain.Entities;
using DPTS.Web.Models;

namespace DPTS.Web.Controllers
{
    public class EmailController : BaseController
    {
      #region Fields
        private readonly IEmailService _emailService;
        #endregion

        #region Contructor
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        #endregion

        #region Methods
        //public ActionResult List()
        //{
        //    var emailes = _emailService.GetAllEmailes(true);
        //    var model = emailes.Select(c => new EmailViewModel()
        //    {
        //        Id=c.Id,
        //        Name=c.Name,
        //        DisplayOrder=c.DisplayOrder,
        //        NumericIsoCode=c.NumericIsoCode,
        //        Published=c.Published,
        //        SubjectToVat=c.SubjectToVat,
        //        ThreeLetterIsoCode=c.ThreeLetterIsoCode,
        //        TwoLetterIsoCode=c.TwoLetterIsoCode

        //    }).ToList();
        //    return System.Web.UI.WebControls.View(model);
        //}
        public ActionResult Create()
        {
            var model = new EmailViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(EmailViewModel model)
        {
            if(ModelState.IsValid)
            {
                var country = new Country
                {
                    Name=model.Name,
                    TwoLetterIsoCode=model.TwoLetterIsoCode,
                    ThreeLetterIsoCode=model.ThreeLetterIsoCode,
                    NumericIsoCode=model.NumericIsoCode,
                    SubjectToVat=model.SubjectToVat,
                    Published=model.Published,
                    DisplayOrder=model.DisplayOrder
                };
           //y     _emailService.InsertEmail(EmailViewModel);
          //y      return RedirectToAction("List");
            }
            return View(model);
        }
        public ActionResult Edit(int Id)
        {
            if (!IsValidateId(Id))
                return HttpNotFound();

            var country = _emailService.GetCountryById(Id);
            if (country == null)
                return HttpNotFound();

            var model = new EmailViewModel
            {
                Id = country.Id,
                Name = country.Name,
                DisplayOrder = country.DisplayOrder,
                NumericIsoCode = country.NumericIsoCode,
                Published = country.Published,
                SubjectToVat = country.SubjectToVat,
                ThreeLetterIsoCode = country.ThreeLetterIsoCode,
                TwoLetterIsoCode = country.TwoLetterIsoCode
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(CountryViewModel model)
        {
            if(ModelState.IsValid)
            {
                var country = _emailService.GetCountryById(model.Id);
                country.Id = model.Id;
                country.Name = model.Name;
                country.DisplayOrder = model.DisplayOrder;
                country.NumericIsoCode = model.NumericIsoCode;
                country.Published = model.Published;
                country.SubjectToVat = model.SubjectToVat;
                country.ThreeLetterIsoCode = model.ThreeLetterIsoCode;
                country.TwoLetterIsoCode = model.TwoLetterIsoCode;
                _emailService.UpdateCountry(country);
      //y          return RedirectToAction("List");
            }
            return View();
        }


        public ActionResult DeleteConfirmed(int id)
        {
            var country = _emailService.GetCountryById(id);
            if (country != null)
                _emailService.DeleteCountry(country);


            return Content("Deleted");
        }
        #endregion

        //public ActionResult Index()
        //{
        //    return View();
        //}
	}
}