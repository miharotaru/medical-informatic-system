#pragma checksum "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\AppointmentComponents\AddAppointment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54e9f85e7e034d78f1ea9ee47284bb446e302d53"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Pages.AppointmentComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\_Imports.razor"
using BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\_Imports.razor"
using BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\AppointmentComponents\AddAppointment.razor"
using BlazorCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-appointment")]
    public partial class AddAppointment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Add Appointment</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"FirstName\" class=\"control-label\">Medic</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "FirstName");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\AppointmentComponents\AddAppointment.razor"
                                                                     objAppointment.Medic

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objAppointment.Medic = __value, objAppointment.Medic));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"LastName\" class=\"control-label\">Patient</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "form", "LastName");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\AppointmentComponents\AddAppointment.razor"
                                                                    objAppointment.Patient

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objAppointment.Patient = __value, objAppointment.Patient));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"Date\" class=\"control-label\">Appointment Date</label>\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "form", "Date");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\AppointmentComponents\AddAppointment.razor"
                                                                objAppointment.Date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objAppointment.Date = __value, objAppointment.Date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-md-4");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\AppointmentComponents\AddAppointment.razor"
                                                                        CreateAppointment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-primary");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\AppointmentComponents\AddAppointment.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\AppointmentComponents\AddAppointment.razor"
        Appointment objAppointment = new Appointment();

            protected void CreateAppointment()
            {
                appointmentRepository.CreateAppointment(objAppointment);
                NavigationManager.NavigateTo("appointment");
            }
            void Cancel()
            {
                NavigationManager.NavigateTo("appointment");
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppointmentRepository appointmentRepository { get; set; }
    }
}
#pragma warning restore 1591
