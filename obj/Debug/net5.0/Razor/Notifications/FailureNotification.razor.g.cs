#pragma checksum "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.Components\Notifications\FailureNotification.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb4c4d0bec0ba0afab217e376ef92733c04aee68"
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
    public partial class FailureNotification : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "failure-notification");
            __builder.OpenComponent<Carlton.Base.Client.Components.BaseNotification>(2);
            __builder.AddAttribute(3, "IconClass", "mdi-alert-circle-outline");
            __builder.AddAttribute(4, "BackgroundClass", "failure-notification");
            __builder.AddAttribute(5, "Message", "An Error Has Occured");
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
