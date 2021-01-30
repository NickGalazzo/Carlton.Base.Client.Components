// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class TabBarBase : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\nicho\Documents\code\Project Carlton\libs\Carlton.Base.Client.Components\Tab\TabBarBase.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public Tab ActiveTab { get; set; }

    protected List<Tab> _tabs = new List<Tab>();

    protected int _tabCount;

    protected int _activeTabIndex;

    internal void AddTab(Tab tab)
    {
        _tabCount = _tabCount + 1;
        tab.TabIndex = _tabCount - 1;

        _tabs.Add(tab);
        if(_tabs.Count == 1)
            ActiveTab = tab;
        StateHasChanged();
    }

    internal void ActivateTab(Tab tab)
    {
        ActiveTab = tab;
        _activeTabIndex = tab.TabIndex;
    }

    private string GetButtonClass(Tab tab)
    {
        return tab == ActiveTab ? "btn-primary" : "btn-secondary";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
