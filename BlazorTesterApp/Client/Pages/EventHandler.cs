using Microsoft.AspNetCore.Components;

namespace BlazorTesterApp.Client
{
    public class CustomEventArgs : EventArgs
    {
        public string CustomProperty1 { get; set; }
    }

    [EventHandler("onclosed", typeof(CustomEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
    public static class EventHandlers
    {
    }
}
