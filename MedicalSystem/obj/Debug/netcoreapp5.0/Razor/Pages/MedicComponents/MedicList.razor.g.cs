#pragma checksum "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89a346b8ff6af9ec99bf6282e3a43b38eb3f512b"
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
#line 1 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\_Imports.razor"
using MedicalSystems;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\_Imports.razor"
using MedicalSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
using MedicalSystems.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/medic")]
    public partial class MedicList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "add-medic");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<button class=\"btn btn-success\">Add Medic</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>Medics</h1>");
#nullable restore
#line 10 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
 if (objMedics == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading....</em></p>");
#nullable restore
#line 12 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
                                }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>Medic Id</th>\r\n                <th>Name</th>\r\n                <th>Specialty</th>\r\n                <th>Rate per Hour</th>\r\n                <th>Action</th></tr></thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 26 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
             foreach (var med in objMedics)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 29 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
                     med.MedicId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 30 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
                     med.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 31 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
                     med.Specialty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 32 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
                     med.RatePerHour

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "class", "nav-link");
            __builder.AddAttribute(28, "href", "update-medic/" + (
#nullable restore
#line 34 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
                                                            med.MedicId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "<span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>Edit\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "delete-medic/" + (
#nullable restore
#line 37 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
                                                            med.MedicId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>Delete\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
            }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Pages\MedicComponents\MedicList.razor"
        List<Medic> objMedics;
    protected override async Task OnInitializedAsync()
    {
        objMedics = await Task.Run(() => medicRepository.GetMedics());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MedicRepository medicRepository { get; set; }
    }
}
#pragma warning restore 1591
