#pragma checksum "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c832b8c68361dcfe2bb5372343bb1cd0cdb5435"
// <auto-generated/>
#pragma warning disable 1591
namespace MedicalSystem.Pages.MedicComponents
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
#line 2 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
using MedicalSystems.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-medic")]
    public partial class AddMedic : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Add Medic</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"Name\" class=\"control-label\">Last Name</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "Name");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
                                                                objMedic.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMedic.Name = __value, objMedic.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"Specialty\" class=\"control-label\">Specialty</label>\r\n                ");
            __builder.OpenElement(18, "select");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
                                objMedic.Specialty

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMedic.Specialty = __value, objMedic.Specialty));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value");
            __builder.AddContent(24, "General");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "Cardiology");
            __builder.AddContent(28, "Cardiology");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "Psychology");
            __builder.AddContent(32, "Psychology");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "Hematology");
            __builder.AddContent(36, "Hematology");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group");
            __builder.AddMarkupContent(40, "<label for=\"RatePerHour\" class=\"control-label\">Rate per Hour</label>\r\n                ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "form", "RatePerHour");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
                                                                       objMedic.RatePerHour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMedic.RatePerHour = __value, objMedic.RatePerHour));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-md-4");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "form-group");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
                                                                        CreateMedic

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "class", "btn btn-primary");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
        Medic objMedic = new Medic();

            protected void CreateMedic()
            {
                medicRepository.CreateMedic(objMedic);
                NavigationManager.NavigateTo("medic");
            }
            void Cancel()
            {
                NavigationManager.NavigateTo("medic");
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MedicRepository medicRepository { get; set; }
    }
}
#pragma warning restore 1591
