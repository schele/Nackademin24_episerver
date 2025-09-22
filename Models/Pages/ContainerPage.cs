using nackademin24_episerver.Business;
using nackademin24_episerver.Business.Attributes;
using nackademin24_episerver.Business.Enums;
using nackademin24_episerver.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_episerver.Models.Pages
{
    [ContentType(
        GUID = "70195022-6CC7-4C2C-8A49-CA637FD6DAF3",
        GroupName = Globals.GroupNames.Specialized,
        DisplayName = "Container"
    )]
    [AvailableContentTypes(
        Availability.Specific,
        Include = [typeof(CarouselPage)]
    )]
    [ContentIcon(ContentIcon.Folder)]
    public class ContainerPage : PageData, IContainerPage
    {
    }
}