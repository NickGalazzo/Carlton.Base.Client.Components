#pragma checksum "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Infrastructure.Client\Components\TestBed\TestBed\TestBed.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d025d814a4a94fbe2ac6aa01dddbd5fdd21c52a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Carlton.Base.Infrastructure.Client.Components.TestBed.TestBed
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Infrastructure.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class TestBed : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Infrastructure.Client\Components\TestBed\TestBed\TestBed.razor"
       

    [Parameter]
    public Type ComponentType
    {
        get { return componentType; }
        set
        {
            if(!(typeof(ComponentBase).IsAssignableFrom(value)))
                throw new InvalidOperationException("ComponentType is not a valid component type.");
            componentType = value;
        }
    }
    private Type componentType;

    [Parameter]
    public object ViewModel { get; set; }

    private RenderFragment TestComponentFragment { get; set; }

    protected override void OnParametersSet()
    {
        TestComponentFragment = builder =>
        {
            builder.OpenElement(1, "div");
            builder.OpenComponent(2, ComponentType);
            builder.AddAttribute(1, "ViewModel", ViewModel);
            builder.CloseComponent();
            builder.CloseElement();
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591