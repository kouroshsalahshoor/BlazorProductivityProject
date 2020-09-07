#pragma checksum "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\Pages\HRM\EmployeeAddEditDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7103468bc88867902cc9796da63bf2f0410df44"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorProductivityProject.Pages.HRM
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee/add")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee/edit/{Id}")]
    public partial class EmployeeAddEditDelete : OwningComponentBase<ApplicationDbContext>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "C:\Users\k.salahshoor\Desktop\BlazorProductivityProject\BlazorProductivityProject\Pages\HRM\EmployeeAddEditDelete.razor"
      
    ApplicationDbContext _db => Service;
    [Parameter] public string Id { get; set; }

    [Inject] public NavigationManager _NavigationManager { get; set; }

    protected Employee _model { get; set; } = new Employee();
    protected List<Country> _countries { get; set; } = new List<Country>();
    protected List<JobCategory> _jobCategories { get; set; } = new List<JobCategory>();

    protected string _selectedCountryId = string.Empty;
    protected string _selectedJobCategoryId = string.Empty;

    protected string _message = string.Empty;
    protected string _statusClass = string.Empty;
    protected bool _saved;

    protected override async Task OnInitializedAsync()
    {
        _saved = false;
        _countries = await _db.Countries.ToListAsync();
        _jobCategories = await _db.JobCategories.ToListAsync();

        int.TryParse(Id, out var employeeId);

        if (employeeId == 0) //new employee is being created
        {
            //add some defaults
            _model = new Employee { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
        }
        else
        {
            _model = await _db.Employees.FindAsync(employeeId);
        }

        _selectedCountryId = _model.CountryId.ToString();
        _selectedJobCategoryId = _model.JobCategoryId.ToString();
    }

    protected async Task HandleValidSubmit()
    {
        _saved = false;

        _model.CountryId = int.Parse(_selectedCountryId);
        _model.JobCategoryId = int.Parse(_selectedJobCategoryId);

        if (_model.Id == 0) //new
        {
            await _db.Employees.AddAsync(_model);
        }
        else
        {
            _db.Employees.Update(_model);
        }

        var result = await _db.SaveChangesAsync();
        if (result > 0)
        {
            _statusClass = "alert-success";
            _message = "Save was successful.";
            _saved = true;
        }
        else
        {
            _statusClass = "alert-danger";
            _message = "Something went wrong saving the item. Please try again.";
        }
    }

    protected async Task DeleteEmployee()
    {
        _saved = false;

        _db.Employees.Remove(_model);
        var result = await _db.SaveChangesAsync();
        if (result > 0)
        {
            _statusClass = "alert-success";
            _message = "Delete was successful.";
            _saved = true;
        }
        else
        {
            _statusClass = "alert-danger";
            _message = "Something went wrong deleting the item. Please try again.";
        }
    }

    protected void NavigateToList()
    {
        _NavigationManager.NavigateTo("/employees");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591