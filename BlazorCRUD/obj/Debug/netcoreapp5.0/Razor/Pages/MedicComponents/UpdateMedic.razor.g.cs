#pragma checksum "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\UpdateMedic.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bef8a71cf6ce54a117f0008de3e082f368c09bb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Pages.MedicComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\_Imports.razor"
using BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\_Imports.razor"
using BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\UpdateMedic.razor"
using BlazorCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/update-medic/{CurrentID}")]
    public partial class UpdateMedic : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Update Medic</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"FirstName\" class=\"control-label\">First Name</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "FirstName");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\UpdateMedic.razor"
                                                                     objMedic.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMedic.FirstName = __value, objMedic.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"LastName\" class=\"control-label\">Last Name</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "form", "LastName");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\UpdateMedic.razor"
                                                                    objMedic.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMedic.LastName = __value, objMedic.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"Specialty\" class=\"control-label\">Specialty</label>\r\n                ");
            __builder.OpenElement(27, "select");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\UpdateMedic.razor"
                                objMedic.Specialty

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objMedic.Specialty = __value, objMedic.Specialty));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value");
            __builder.AddContent(33, "General");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "Cardiology");
            __builder.AddContent(37, "Cardiology");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "Hematology");
            __builder.AddContent(41, "Hematology");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "Psychology");
            __builder.AddContent(45, "Psychology");
            __builder.CloseElement();
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
#line 33 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\UpdateMedic.razor"
                                                                        UpdateMedicInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "value", "Update");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "class", "btn btn-primary");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\UpdateMedic.razor"
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
#line 40 "C:\Users\Catalin\Desktop\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\UpdateMedic.razor"
        [Parameter]
            public string CurrentID { get; set; }
            Medic objMedic = new Medic();

            protected override async Task OnInitializedAsync()
            {
                objMedic = await Task.Run(() => medicRepository.GetMedicById(Convert.ToInt32(CurrentID)));
            }

            protected void UpdateMedicInfo()
            {
                medicRepository.UpdateMedic(objMedic);
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
