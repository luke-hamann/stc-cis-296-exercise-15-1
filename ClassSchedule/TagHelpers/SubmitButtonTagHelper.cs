using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ClassSchedule.TagHelpers
{
    [HtmlTargetElement("button", Attributes = "[type=submit]")]
    public class SubmitButtonTagHelper : TagHelper
    {
    }
}
