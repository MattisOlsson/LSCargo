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

        [Field(Title="Information")]
        public HtmlField Content { get; set; }

    }
}
