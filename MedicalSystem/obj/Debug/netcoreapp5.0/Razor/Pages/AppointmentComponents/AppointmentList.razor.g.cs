#pragma checksum "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e93d803b774a5fbc2dacd4f213b5cdfbb0cf6b9"
// <auto-generated/>
#pragma warning disable 1591
namespace MedicalSystem.Pages.AppointmentComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\_Imports.razor"
using MedicalSystems;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\_Imports.razor"
using MedicalSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
using MedicalSystems.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/appointment")]
    public partial class AppointmentList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "add-appointment");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<button class=\"btn btn-primary\"><span class=\"oi oi-chevron-bottom\" aria-hidden=\"true\"></span> Add Appointment</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n<br><br>\r\n");
            __builder.AddMarkupContent(6, "<h1>Appointments</h1>");
#nullable restore
#line 10 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
 if (objAppointments == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading....</em></p>");
#nullable restore
#line 12 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
                                }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>Appointment Id</th>\r\n                <th>Medic</th>\r\n                <th>Patient</th>\r\n                <th>Appointment Date</th>\r\n                <th>Prescription Id</th>\r\n                <th>Action</th></tr></thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 27 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
             foreach (var appointment in objAppointments)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
#nullable restore
#line 30 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
__builder.AddContent(14, appointment.AppointmentId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 31 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
__builder.AddContent(17, appointment.Medic);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 32 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
__builder.AddContent(20, appointment.Patient);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 33 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
__builder.AddContent(23, appointment.Date);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 34 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
__builder.AddContent(26, appointment.PrescriptionId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "update-appointment/" + (
#nullable restore
#line 36 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
                                                                      appointment.AppointmentId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>Edit\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "class", "nav-link");
            __builder.AddAttribute(36, "href", "delete-appointment/" + (
#nullable restore
#line 39 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
                                                                  appointment.AppointmentId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>Delete\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\AppointmentList.razor"
        List<Appointment> objAppointments;

    protected override async Task OnInitializedAsync()
    {
        objAppointments = await Task.Run(() => appointmentRepository.GetAppointments());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppointmentRepository appointmentRepository { get; set; }
    }
}
#pragma warning restore 1591
