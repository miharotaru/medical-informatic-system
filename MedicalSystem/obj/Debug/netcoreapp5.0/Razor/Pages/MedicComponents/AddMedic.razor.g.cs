#pragma checksum "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53acc25333bb1953a2db4b00874294b349e78083"
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
#line 1 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\_Imports.razor"
using MedicalSystems;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\_Imports.razor"
using MedicalSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
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
            __builder.AddMarkupContent(0, "<h2>Add Medic</h2>\r\n<hr>\r\n ");
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "class", "text-danger");
#nullable restore
#line 8 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
__builder.AddContent(3, validationMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "form");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-8");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-group");
            __builder.AddMarkupContent(12, "<label for=\"Name\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "form", "Name");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
                                                                objMedic.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMedic.Name = __value, objMedic.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "<label for=\"Specialty\" class=\"control-label\">Specialty</label>\r\n                ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
                                objMedic.Specialty

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMedic.Specialty = __value, objMedic.Specialty));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "General");
            __builder.AddContent(28, "General");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "Cardiology");
            __builder.AddContent(32, "Cardiology");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "Psychology");
            __builder.AddContent(36, "Psychology");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "Hematology");
            __builder.AddContent(40, "Hematology");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group");
            __builder.AddMarkupContent(44, "<label for=\"RatePerHour\" class=\"control-label\">Rate per Hour $</label>\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "form", "RatePerHour");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
                                                                       objMedic.RatePerHour

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMedic.RatePerHour = __value, objMedic.RatePerHour));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-md-4");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
                                                                        CreateMedic

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "type", "button");
            __builder.AddAttribute(65, "class", "btn btn-primary");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Catalin\Desktop\MEdical ceva\medical-informatic-system\MedicalSystem\Pages\MedicComponents\AddMedic.razor"
       
    Medic objMedic = new Medic();
    string validationMessage = "Here you can add a medic";

    protected void CreateMedic()
    {
        if (MedicValidations.ValidateMedic(objMedic.Name, objMedic.RatePerHour))
        {
            medicRepository.CreateMedic(objMedic);
            NavigationManager.NavigateTo("medic");
        }
        else
        {
            validationMessage = "Please verify that the rate per hour is greater than 0 and the medic name is not empty and starts with uppercase";
        }   
    }
    
    void Cancel()
    {   
        StateHasChanged();
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
