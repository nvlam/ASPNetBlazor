#pragma checksum "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33d4fc49037e274f5d8f87807ecc992c01d271fe"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails")]
    public partial class EmployeeDetails : EmployeeDetaislBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
 if(Employee==null || Employee.Department==null)
 {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"spinner\"></div>");
#nullable restore
#line 8 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
      }
else
            {    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center m-3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-8");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.OpenElement(9, "h1");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                      Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 15 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                          Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " ");
            __builder.AddContent(14, 
#nullable restore
#line 15 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                                             Cordinates

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card-body text-center");
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "class", "card-img-top");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 20 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                                Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                   e=> Cordinates = $"X= {e.ClientX} Y={e.ClientY}"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n                ");
            __builder.OpenElement(23, "h4");
            __builder.AddContent(24, " Employee ID: ");
            __builder.AddContent(25, 
#nullable restore
#line 23 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                   Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "h4");
            __builder.AddContent(28, " Email: ");
            __builder.AddContent(29, 
#nullable restore
#line 24 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                             Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "h4");
            __builder.AddContent(32, " Department: ");
            __builder.AddContent(33, 
#nullable restore
#line 25 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                  Employee.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                                           ButtonClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, 
#nullable restore
#line 26 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                                                         ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 29 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                                 CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "<a href=\"/\" class=\"btn btn-primary\">  Back </a>\r\n                ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", 
#nullable restore
#line 31 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                           $"editemployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "class", "btn btn-primary");
            __builder.AddContent(46, "  Edit ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.AddMarkupContent(48, "<a href=\"#\" class=\"btn btn-danger\">  Delete </a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
