using System;
using System.Collections.Generic;
using System.Linq;
using LSCargo.Web.Models.Regions;
using Microsoft.AspNetCore.Mvc;
using Piranha;
using Piranha.Data;
using Piranha.Extend.Fields;

namespace LSCargo.Web.Controllers
{
    public class PrototypeController : Controller
    {
        private readonly IApi _api;

        public PrototypeController(IApi api)
        {
            _api = api;
        }

    
        [Route("prototype/contact")]
        public IActionResult Contact()
        {
            Media media = _api.Media.GetAll().FirstOrDefault();

            var model = new List<ContactCard>();
            var image = new ImageField
            {
                Id = media.Id
            };

            image.Init(_api);

            model.Add(new ContactCard
            {
                Image = image,
                Name = "Jane Doe",
                Email = "jane.doe@lscargo.com",
                Phone = "+46701234567"
            });

            model.Add(new ContactCard
            {
                Image = image,
                Name = "John Doe",
                Email = "john.doe@lscargo.com",
                Phone = "+46701234567"
            });

            model.Add(new ContactCard
            {
                Image = image,
                Name = "Jane Doe",
                Email = "jane.doe@lscargo.com",
                Phone = "+46701234567"
            });

            model.Add(new ContactCard
            {
                Image = image,
                Name = "John Doe",
                Email = "john.doe@lscargo.com",
                Phone = "+46701234567"
            });

            model.Add(new ContactCard
            {
                Image = image,
                Name = "Jane Doe",
                Email = "jane.doe@lscargo.com",
                Phone = "+46701234567"
            });

            model.Add(new ContactCard
            {
                Image = image,
                Name = "John Doe",
                Email = "john.doe@lscargo.com",
                Phone = "+46701234567"
            });

            return View("~/Views/Prototype/Contact.cshtml", model);
        }
    }
}