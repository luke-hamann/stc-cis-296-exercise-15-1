using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ClassSchedule.TagHelpers
{
    public class MyLinkButtonTagHelper : TagHelper
    {
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Id { get; set; }
    }
}
