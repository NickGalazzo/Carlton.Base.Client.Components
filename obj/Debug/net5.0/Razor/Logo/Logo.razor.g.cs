#pragma checksum "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.Components\Logo\Logo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1b93941aadcd817325a0958897d885d520efb8f"
// <auto-generated/>
#pragma warning disable 1591
namespace Carlton.Base.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.Components\_imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class Logo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "logo" + " " + (
#nullable restore
#line 3 "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.Components\Logo\Logo.razor"
                   IsCollapsed ? "collapsed" : string.Empty

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "b-w5ij3lmvn7");
            __builder.AddMarkupContent(3, @"<span b-w5ij3lmvn7><img src=""https://paradisebound.org/wp-content/uploads/2016/09/paradise-bound-ministries-mission-teams-homes-built-and-dedicated-house-icon.png"" height=""50"" width=""50"" alt=""Image result for house icon"" b-w5ij3lmvn7>
        <span class=""title"" b-w5ij3lmvn7>Carlton Test Bed</span></span>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.Components\Logo\Logo.razor"
      
    [CascadingParameter] bool IsCollapsed { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
