using nackademin24_episerver.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace nackademin24_episerver.Models.Blocks
{
    [ContentType(
        GUID = "49457F46-E6AB-4574-A2B1-BA37B91B72D4",
        DisplayName = "Carousel"
    )]
    public class CarouselBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [AllowedTypes(typeof(CarouselPage))]
        public virtual ContentArea Carousel { get; set; }
    }
}