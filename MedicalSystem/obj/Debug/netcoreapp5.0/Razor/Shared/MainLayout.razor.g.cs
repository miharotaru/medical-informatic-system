<<<<<<< HEAD
#pragma checksum "C:\Users\Catalin\Desktop\Medical System\medical-informatic-system\MedicalSystem\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ccd4cacc109a1ae5ff1b1cbe3d91323a49ab655"
=======
#pragma checksum "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "883fc7c4bce04ac3289254fbc2acf3c13564ac92"
>>>>>>> e6cca1154f937d085edd0bcfdb8233506e769cdc
// <auto-generated/>
#pragma warning disable 1591
namespace MedicalSystem.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddAttribute(2, "style", "background: #8E2DE2;\r\n     background: -webkit-linear-gradient(to right, #4A00E0, #8E2DE2);\r\n     background: linear-gradient(to right, #4A00E0, #8E2DE2);");
            __builder.OpenComponent<MedicalSystem.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "main hero");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "content px-4");
            __builder.AddContent(9, 
#nullable restore
#line 12 "C:\Users\Mihaela\Desktop\licenta_aplicatie\medical-informatic-system\MedicalSystem\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
