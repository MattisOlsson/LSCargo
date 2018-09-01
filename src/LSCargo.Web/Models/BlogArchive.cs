using Piranha.AttributeBuilder;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace LSCargo.Web.Models
{
    [PageType(Title = "Blog archive", UseBlocks = false)]
    public class BlogArchive  : BlogPage<BlogArchive>
    {
        /// <summary>
        /// Gets/sets the archive heading.
        /// </summary>
        [Region]
        public Regions.Heading Heading { get; set; }
    }
}