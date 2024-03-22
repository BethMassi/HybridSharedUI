using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace MyApp.Shared
{
    // Set the interactive render modes for use by components in the Shared class library which can be overridden by the MAUI client.
    public static class InteractiveRenderSettings
    {
        public static IComponentRenderMode? InteractiveServer { get; set; } = RenderMode.InteractiveServer;
        public static IComponentRenderMode? InteractiveAuto { get; set; } = RenderMode.InteractiveAuto;
        public static IComponentRenderMode? InteractiveWebAssembly { get; set; } = RenderMode.InteractiveWebAssembly;
    }
}
