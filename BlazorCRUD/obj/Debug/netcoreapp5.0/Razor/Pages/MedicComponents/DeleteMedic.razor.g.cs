#pragma checksum "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\DeleteMedic.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74175e603c858dc0f27524702168b86762eb3b34"
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
#line 2 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\DeleteMedic.razor"
using BlazorCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete-medic/{CurrentID}")]
    public partial class DeleteMedic : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Delete Medic</h2>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<h3>Are you sure want to delete this medic?</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label>Medic Id:</label>\r\n            ");
            __builder.OpenElement(9, "label");
#nullable restore
#line 14 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\DeleteMedic.razor"
__builder.AddContent(10, objMedic.MedicId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-group");
            __builder.AddMarkupContent(14, "<label>Specialty:</label>\r\n            ");
            __builder.OpenElement(15, "label");
#nullable restore
#line 18 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\DeleteMedic.razor"
__builder.AddContent(16, objMedic.Specialty);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-md-4");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-danger");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\DeleteMedic.razor"
                                                                   DeleteMedicInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\DeleteMedic.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\BlazorCRUD\Pages\MedicComponents\DeleteMedic.razor"
        [Parameter]
            public string CurrentID { get; set; }
            Medic objMedic = new Medic();

            protected override async Task OnInitializedAsync()
            {
                objMedic = await Task.Run(() => medicRepository.GetMedicById(Convert.ToInt32(CurrentID)));
            }

            protected void DeleteMedicInfo()
            {
                medicRepository.DeleteMedic(objMedic);
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
