#pragma checksum "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\ParentChildDemo\ChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66f1610e9e8f07d33219ca892e8cfb0e914b4cc5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorProductivityProject.Pages.Demos.ParentChildDemo
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorProductivityProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorProductivityProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorProductivityProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorProductivityProject.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorProductivityProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    public partial class ChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\ParentChildDemo\ChildComponent.razor"
       
    [Parameter] public string Title { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; } /*must be called ChildContent to work*/
    //[Parameter] public string Content { get; set; }

    private void click(string s)
    {
        childSenderMethod.InvokeAsync(s);
    }

    [Parameter] public EventCallback<string> childSenderMethod { get; set; }
    //[Parameter] public EventCallback<MouseEventArgs> childClickMethod { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
