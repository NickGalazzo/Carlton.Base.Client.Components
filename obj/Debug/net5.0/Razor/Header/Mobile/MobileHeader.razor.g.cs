#pragma checksum "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.Components\Header\Mobile\MobileHeader.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "892fde8365d95b8c5aab4d5d5ddd0015ca221b6e"
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
    public partial class MobileHeader : Header
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "collapsed-header");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-1 title");
            __builder.OpenElement(6, "span");
            __builder.AddContent(7, 
#nullable restore
#line 9 "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.Components\Header\Mobile\MobileHeader.razor"
                 LogoContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-1");
            __builder.OpenElement(11, "span");
            __builder.AddContent(12, 
#nullable restore
#line 14 "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.Components\Header\Mobile\MobileHeader.razor"
                 MenuContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-10 action");
            __builder.AddContent(16, 
#nullable restore
#line 19 "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.Components\Header\Mobile\MobileHeader.razor"
             ActionContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591