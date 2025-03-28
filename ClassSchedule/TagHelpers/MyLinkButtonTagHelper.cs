using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace ClassSchedule.TagHelpers
{
    public class MyLinkButtonTagHelper : TagHelper
    {
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Id { get; set; }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewCtx { get; set; } = null!;

        private LinkGenerator linkBuilder;
        public MyLinkButtonTagHelper(LinkGenerator lg) => linkBuilder = lg;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string action = Action ?? ViewCtx.RouteData.Values["action"].ToString();
            string controller = Controller ?? ViewCtx.RouteData.Values["controller"].ToString();
            var id = new { Id };
            string url = linkBuilder.GetPathByAction(action, controller, id) ?? "";

            string css = "btn ";
            css += (ViewCtx.RouteData.Values["id"]?.ToString() == Id) ? "btn-dark" : "btn-outline-dark";
        }
    }
}
