#pragma checksum "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\DeleteAppointment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b56b899dc565cc22c1ff414cf1c43b07c428c39"
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
#line 2 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\DeleteAppointment.razor"
using MedicalSystems.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete-appointment/{CurrentID}")]
    public partial class DeleteAppointment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Delete Appointment</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>Are you sure want to delete this appointment?</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label>Appointment Id:</label>\r\n            ");
            __builder.OpenElement(9, "label");
#nullable restore
#line 14 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\DeleteAppointment.razor"
__builder.AddContent(10, objAppointment.AppointmentId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-4");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "btn btn-danger");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\DeleteAppointment.razor"
                                                                   DeleteAppointmentInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\DeleteAppointment.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\AppointmentComponents\DeleteAppointment.razor"
        [Parameter]
            public string CurrentID { get; set; }
            Appointment objAppointment = new Appointment();

            protected override async Task OnInitializedAsync()
            {
                objAppointment = await Task.Run(() => appointmentRepository.GetAppointmentById(Convert.ToInt32(CurrentID)));
            }

            protected void DeleteAppointmentInfo()
            {
                appointmentRepository.DeleteAppointment(objAppointment);
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