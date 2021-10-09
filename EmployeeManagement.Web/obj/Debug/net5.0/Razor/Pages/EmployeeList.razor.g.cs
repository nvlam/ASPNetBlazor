#pragma checksum "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69d1174dcec740bf470b198b9902bba924abf740"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EmployeeList</h3>");
#nullable restore
#line 5 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
 if (Employees == null) { 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"spinner\"></div>");
#nullable restore
#line 7 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck");
#nullable restore
#line 11 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
     foreach (var employee in Employees)
     {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card m-3");
            __builder.AddAttribute(6, "style", "min-width: 18rem; max-width: 30%;");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.OpenElement(9, "h2");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
                  employee.DepartmentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "h3");
            __builder.AddContent(13, 
#nullable restore
#line 16 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
                  employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " ");
            __builder.AddContent(15, 
#nullable restore
#line 16 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                      employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "class", "imageThumbnail");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 18 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                          employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.AddMarkupContent(21, "<div class=\"card-footer text-center\"><a href=\"#\" class=\"btn btn-primary m-1\"> View </a>\r\n            <a href=\"#\" class=\"btn btn-primary m-1\"> Edit </a>\r\n            <a href=\"#\" class=\"btn btn-danger m-1\"> Delete </a></div>");
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
