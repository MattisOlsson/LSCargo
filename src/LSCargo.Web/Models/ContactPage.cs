using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LSCargo.Web.Models.Regions;
using Piranha.AttributeBuilder;
using Piranha.Models;

namespace LSCargo.Web.Models
{
    [PageType(Title = "Contact page")]
    [PageTypeRoute(Title = "Contact", Route = "/Contact")]
    public class ContactPage : Page<ContactPage>
    {
        [Region(Title = "Header")]
        public Heading Heading { get; set; }

        [Region(ListTitle= "Name")]
        public IList<Speaker> Speakers { get; set; }
        
        public ContactPage()
        {
            Speakers = new List<Speaker>();

        }
    }
}
