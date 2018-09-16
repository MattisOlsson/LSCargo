using Piranha.Extend.Fields;
using Piranha.AttributeBuilder;

namespace LSCargo.Web.Models.Regions
{
    public class Speaker
    {
        [Field(Title = "Profilbild")]
        public ImageField ProfilePicture { get; set; }

        [Field(Title="Namn")]
        public StringField Name { get; set; }

        [Field(Title = "E-Post")]
        public StringField Email { get; set; }

        [Field(Title= "Telefon")]
        public StringField Phone { get; set; }
    }
}
