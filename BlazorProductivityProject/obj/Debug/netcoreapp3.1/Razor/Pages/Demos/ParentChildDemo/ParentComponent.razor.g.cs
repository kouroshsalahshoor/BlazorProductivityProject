#pragma checksum "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\ParentChildDemo\ParentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "475d5fb11013c8d5541e9dfa300ad2346e4ddfd1"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/parent")]
    public partial class ParentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Parent Component</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorProductivityProject.Pages.Demos.ParentChildDemo.ChildComponent>(1);
            __builder.AddAttribute(2, "Title", "child title from parent");
            __builder.AddAttribute(3, "childSenderMethod", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 5 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\ParentChildDemo\ParentComponent.razor"
                                   parentRecieverMethod

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.AddMarkupContent(6, "<h1 class=\"text-danger\">child content from parent</h1>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\r\n<br>\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, 
#nullable restore
#line 11 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\ParentChildDemo\ParentComponent.razor"
    message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\ParentChildDemo\ParentComponent.razor"
       
    private string message;
    private void parentRecieverMethod(string s)
    {
        message = s;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591