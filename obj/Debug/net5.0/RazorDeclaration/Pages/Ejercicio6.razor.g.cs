// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea_V.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Tarea_V;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\_Imports.razor"
using Tarea_V.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio6.razor"
using Tarea_V.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio6.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio6")]
    public partial class Ejercicio6 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "c:\Users\rrody\Documents\PROGRAMACION\Programacion III\Tarea 5\Tarea V\Pages\Ejercicio6.razor"
      
    dynamic Custom() => new northwindContext().OrderDetails
                            .Include(p => p.Order)
                            .Include(c => c.Order.Customer)
                            .AsEnumerable()
                            .GroupBy(Ord => Ord.Order.CustomerId)
                            .Select(Ord => new
                            {
                                Codigo_Cliente = Ord.Select(c => c.Order.Customer.Id).First(),
                                Nombre = Ord.Select(c => $"{c.Order.Customer.FirstName} {c.Order.Customer.LastName}").First(),
                                Cantidad_Money = Ord.Sum(Calc => Calc.Quantity * Calc.UnitPrice)
                            })
                            .OrderByDescending(od => od.Cantidad_Money)
                            .Take(10);



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591