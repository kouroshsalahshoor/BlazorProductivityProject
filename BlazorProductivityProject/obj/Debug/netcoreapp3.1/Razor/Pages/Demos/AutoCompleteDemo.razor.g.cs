#pragma checksum "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\AutoCompleteDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30cf538b30795d21ad7438456ca1e1bff719d800"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorProductivityProject.Pages.Demos
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/AutoCompleteDemo")]
    public partial class AutoCompleteDemo : OwningComponentBase<ApplicationDbContext>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AutoCompleteDemo</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 8 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\AutoCompleteDemo.razor"
    _count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __Blazor.BlazorProductivityProject.Pages.Demos.AutoCompleteDemo.TypeInference.CreateBlazoredTypeahead_0(__builder, 4, 5, 
#nullable restore
#line 10 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\AutoCompleteDemo.razor"
                                 Search

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 10 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\AutoCompleteDemo.razor"
                                                      _selectedItem

#line default
#line hidden
#nullable disable
            , 7, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _selectedItem = __value, _selectedItem)), 8, () => _selectedItem, 9, (context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddContent(11, 
#nullable restore
#line 12 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\AutoCompleteDemo.razor"
         context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(12, "\r\n    ");
            }
            , 13, (context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.AddContent(15, 
#nullable restore
#line 15 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\AutoCompleteDemo.razor"
         context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(16, " ");
                __builder2.OpenElement(17, "strong");
                __builder2.AddContent(18, 
#nullable restore
#line 15 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\AutoCompleteDemo.razor"
                               context.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(20, "\r\n\r\n");
#nullable restore
#line 19 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\AutoCompleteDemo.razor"
 if (_selectedItem != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, "Selected item is: ");
            __builder.AddContent(24, 
#nullable restore
#line 21 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\AutoCompleteDemo.razor"
                          _selectedItem.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 22 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\AutoCompleteDemo.razor"
}


#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\salahshoor\) Programming\$ ))) Blazor\demos $$$\BlazorProductivityProject\BlazorProductivityProject\Pages\Demos\AutoCompleteDemo.razor"
       
    ApplicationDbContext _db => Service;

    List<Product> _filteredItems;
    Product _selectedItem;
    Product _model = new Product();

    int _count;

    private async Task<IEnumerable<Product>> Search(string searchText)
    {
        _filteredItems = await _db.Products.Where(x => x.Name.ToLower().Contains(searchText.ToLower())).ToListAsync();
        _count = _filteredItems.Count();
        return await Task.FromResult(_filteredItems);
    }

    private void validSubmit()
    {

    }

    private void inValidSubmit()
    {

    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorProductivityProject.Pages.Demos.AutoCompleteDemo
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBlazoredTypeahead_0<TItem, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TValue> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg5)
        {
        __builder.OpenComponent<global::Blazored.Typeahead.BlazoredTypeahead<TItem, TValue>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "SelectedTemplate", __arg4);
        __builder.AddAttribute(__seq5, "ResultTemplate", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
