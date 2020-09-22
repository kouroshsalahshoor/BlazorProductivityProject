#pragma checksum "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\CRUD\ProductAppointment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5d473ae4907207f3498a8487b402d9f74340a9f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorProductivityProject.Pages.CRUD
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductAppointment/{ProductId:int}")]
    public partial class ProductAppointment : OwningComponentBase<ApplicationDbContext>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\CRUD\ProductAppointment.razor"
       
    ApplicationDbContext _db => Service;

    [Parameter] public int ProductId { get; set; }

    Appointment _model { get; set; }
    bool _show;

    protected override void OnInitialized()
    {
        _model = new Appointment();
        _model.Date = DateTime.Now;
        _model.Product = _db.Products.Include(x => x.Category).SingleOrDefault(x => x.Id == ProductId);
        _model.ProductId = _model.Product.Id;
    }

    void showAppointment() => _show = true;
    void showProductDetails() => _show = false;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
