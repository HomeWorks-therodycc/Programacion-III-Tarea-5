#pragma checksum "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio7.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "845424d26123e649046f5e472189db2c8b00782f"
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
#line 2 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio7.razor"
using Tarea_V.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio7")]
    public partial class Ejercicio7 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"alert alert-info\" role=\"alert\">\r\nEl total de ventas vendidas en el mes de agosto del 2012\r\n</div>\r\n\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table ");
            __builder.AddMarkupContent(3, "<thead class=\"table-dark\"><tr><td>Total de ventas del mes de agosto</td></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 16 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio7.razor"
         foreach (PurchaseOrders Ventss in Getventas())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio7.razor"
             if (Ventss.SubmittedDate != Fecha)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<tr><td>No hay ventas en el mes de agosto del 2012</td></tr>");
#nullable restore
#line 23 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio7.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 27 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio7.razor"
                         Ventss.CreationDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio7.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio7.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio7.razor"
      
    DateTime Fecha = new DateTime(2012,8,1);
    List<PurchaseOrders> Getventas() => new northwindContext().PurchaseOrders.ToList();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591