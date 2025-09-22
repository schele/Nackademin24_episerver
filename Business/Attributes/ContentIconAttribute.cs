using nackademin24_episerver.Business.Enums;

namespace nackademin24_episerver.Business.Attributes
{
    public class ContentIconAttribute : Attribute
    {
        public ContentIcon Icon { get; set; }

        public ContentIconAttribute(ContentIcon icon)
        {
            Icon = icon;
        }
    }
}