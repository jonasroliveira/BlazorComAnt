
using Microsoft.AspNetCore.Components;

namespace Client.Components;

partial class DynamicDrawer
{
    [Parameter] public bool Visible { get; set; }
    [Parameter] public EventCallback<bool> VisibleChanged { get; set; }

    [Parameter] public string Title { get; set; } = "Drawer";

    [Parameter] public Dictionary<string, object>? Fields { get; set; }

    [Parameter] public RenderFragment? ChildContent { get; set; }
}