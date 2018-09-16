using Piranha;
using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;

namespace LSCargo.Web.Models.Regions
{
    public class ContactCard
    {
        [Field]
        public ImageField Image { get; set; }

        [Field]
        public StringField Name { get; set; }

        [Field]
        public StringField Email { get; set; }

        [Field]
        public StringField Phone { get; set; }
    }
}