#pragma checksum "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\Pages\CRUD\AppointmentsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ec656864102f8f916ff7a2b788ef2e851460e15"
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
#nullable restore
#line 21 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\_Imports.razor"
using BlazorDateRangePicker;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/appointments")]
    public partial class AppointmentsPage : OwningComponentBase<ApplicationDbContext>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\Pages\CRUD\AppointmentsPage.razor"
  ApplicationDbContext _db => Service;

        [Inject] private IJSRuntime _js { get; set; }
        [Inject] private FileService _fileService { get; set; }

        // AuthenticationState is available as a CascadingParameter
        List<Appointment> _items;
        Appointment _model = new Appointment();

    protected override void OnInitialized()
    {
        // Get the current user
        _items = _db.Appointments.Include(x => x.Product).ToList();
    }

    bool _showPopup = false;
    void ClosePopup()
    {
        // Close the Popup
        _showPopup = false;
    }

    void EditAppointment(Appointment appointment)
    {
        _model = appointment;
        _items = _db.Appointments.Include(x => x.Product).ToList();
        _showPopup = true;
    }

    async Task DeleteAppointment()
    {
        _showPopup = false;
        _db.Appointments.Remove(_model);
        var result = await _db.SaveChangesAsync();
        if (result == 0)
        {
            //error
            await _js.InvokeVoidAsync("alert", "Error saving data");
        }
        else
        {
            _model = new Appointment { Product = new Product()};
            _items.Clear();
            _items = await _db.Appointments.Include(x => x.Product).ToListAsync();

            //saved
            await _js.InvokeVoidAsync("alert", "Data saved");

        }
    }

    async Task ValidSubmit()
    {
        _showPopup = false;

        _model.IsConfirmed = true;
        _db.Appointments.Update(_model);
        var result = _db.SaveChanges();
        if (result == 0)
        {
            //error
            await _js.InvokeVoidAsync("alert", "Error saving data");
        }
        else
        {
            //saved
            await _js.InvokeVoidAsync("alert", "Data saved");

            _items.Clear();
            _items = _db.Appointments.Include(x => x.Product).ToList();
        }
    }

    //string convertImageToDisplay(byte[] image)
    //{
    //    if (image != null)
    //    {
    //        var base64 = Convert.ToBase64String(image);
    //        var finalStr = string.Format("data:image/jpg;base64,{0}", base64);
    //        return finalStr;
    //    }

    //    else { return ""; }
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
