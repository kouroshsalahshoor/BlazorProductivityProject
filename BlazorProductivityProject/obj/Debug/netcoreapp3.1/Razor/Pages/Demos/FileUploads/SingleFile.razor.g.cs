#pragma checksum "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\FileUploads\SingleFile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71ee4405f720795de6bb3a33778a42bcf81b9de2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorProductivityProject.Pages.Demos.FileUploads
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorProductivityProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorProductivityProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorProductivityProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorProductivityProject.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorProductivityProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/singlefile")]
    public partial class SingleFile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Single file</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>A single file input that uploads automatically on file selection</p>\r\n\r\n");
            __builder.OpenComponent<BlazorInputFile.InputFile>(2);
            __builder.AddAttribute(3, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 10 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\FileUploads\SingleFile.razor"
                     HandleSelection

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 12 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\FileUploads\SingleFile.razor"
    status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\FileUploads\SingleFile.razor"
       
    [Inject] private IWebHostEnvironment environment { get; set; }
    string status;

    async Task HandleSelection(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file != null)
        {
            var path = Path.Combine(environment.WebRootPath, "uploads", file.Name);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.Data.CopyToAsync(stream);
            }

            status = $"Finished loading {file.Size} bytes from {file.Name}";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
