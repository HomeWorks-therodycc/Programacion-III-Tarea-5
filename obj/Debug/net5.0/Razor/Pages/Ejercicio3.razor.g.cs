#pragma checksum "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6d2c1d22e8554ab27f591a1688d2ac88f36eac9"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_V.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Tarea_V;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Tarea_V.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio3.razor"
using Tarea_V.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio3")]
    public partial class Ejercicio3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"alert alert-info\" role=\"alert\">\r\n    La cantidad de clientes que existen por pais.\r\n</div>\r\n<br>\r\n<br>\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table ");
            __builder.AddMarkupContent(3, "<thead class=\"table-dark\"><tr><td>Pais</td>\r\n            <td>Cantidad de clientes por pais</td></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 23 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio3.razor"
         foreach (var Custom in GetCustomers())
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 26 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio3.razor"
                     Custom.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 27 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio3.razor"
                     Custom.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio3.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio3.razor"
      
    Dictionary<string, int> GetCustomers() => new northwindContext().Customers
        .ToList().GroupBy(pais => pais.CountryRegion)
        .ToDictionary(Cantidad => Cantidad.Key, Cantidad => Cantidad.Count());

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
