#pragma checksum "C:\BLAZOR Licence\BlazorCRUD\Pages\DeleteEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88e3a733e622d6ef40d19eb15a963d5fc548218e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\BLAZOR Licence\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR Licence\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BLAZOR Licence\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\BLAZOR Licence\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\BLAZOR Licence\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\BLAZOR Licence\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\BLAZOR Licence\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\BLAZOR Licence\BlazorCRUD\_Imports.razor"
using BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\BLAZOR Licence\BlazorCRUD\_Imports.razor"
using BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BLAZOR Licence\BlazorCRUD\Pages\DeleteEmployee.razor"
using BlazorCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeleteEmployee/{CurrentID}")]
    public partial class DeleteEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Delete Employee</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>Are you sure want to delete this?</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-8");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<label>Employee ID:</label>\r\n            ");
            __builder.OpenElement(12, "label");
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\BLAZOR Licence\BlazorCRUD\Pages\DeleteEmployee.razor"
                    objEmp.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, "<label>Name:</label>\r\n            ");
            __builder.OpenElement(20, "label");
            __builder.AddContent(21, 
#nullable restore
#line 18 "C:\BLAZOR Licence\BlazorCRUD\Pages\DeleteEmployee.razor"
                    objEmp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, "<label>Gender:</label>\r\n            ");
            __builder.OpenElement(28, "label");
            __builder.AddContent(29, 
#nullable restore
#line 22 "C:\BLAZOR Licence\BlazorCRUD\Pages\DeleteEmployee.razor"
                    objEmp.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-group");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddMarkupContent(35, "<label>Country:</label>\r\n            ");
            __builder.OpenElement(36, "label");
            __builder.AddContent(37, 
#nullable restore
#line 26 "C:\BLAZOR Licence\BlazorCRUD\Pages\DeleteEmployee.razor"
                    objEmp.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "form-group");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.AddMarkupContent(43, "<label>City:</label>\r\n            ");
            __builder.OpenElement(44, "label");
            __builder.AddContent(45, 
#nullable restore
#line 30 "C:\BLAZOR Licence\BlazorCRUD\Pages\DeleteEmployee.razor"
                    objEmp.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "form-group");
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.AddMarkupContent(51, "<label>Salary:</label>\r\n            ");
            __builder.OpenElement(52, "label");
            __builder.AddContent(53, 
#nullable restore
#line 34 "C:\BLAZOR Licence\BlazorCRUD\Pages\DeleteEmployee.razor"
                    objEmp.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "row");
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "col-md-4");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group");
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "type", "button");
            __builder.AddAttribute(69, "class", "btn btn-danger");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\BLAZOR Licence\BlazorCRUD\Pages\DeleteEmployee.razor"
                                                                   DeleteEmpInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "type", "button");
            __builder.AddAttribute(75, "class", "btn btn-primary");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\BLAZOR Licence\BlazorCRUD\Pages\DeleteEmployee.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\BLAZOR Licence\BlazorCRUD\Pages\DeleteEmployee.razor"
       
    [Parameter]
    public string CurrentID { get; set; }
    EmployeeInfo objEmp = new EmployeeInfo();

    protected override async Task OnInitializedAsync()
    {
        objEmp = await Task.Run(() => objEmpService.GetEmployeeById(Convert.ToInt32(CurrentID)));
    }

    protected void DeleteEmpInfo()
    {
        objEmpService.DeleteEmpInfo(objEmp);
        NavigationManager.NavigateTo("Employee");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Employee");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService objEmpService { get; set; }
    }
}
#pragma warning restore 1591
