#pragma checksum "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\TextAreaBinding.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85c86eee893e30be8a98216469dcf964111c1c93"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/textareabinding")]
    public partial class TextAreaBinding : TextAreaBindingBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Two way binding </h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "textarea");
            __builder.AddAttribute(3, "style", "width:500px;");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\TextAreaBinding.razor"
                     Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Description = __value, Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddMarkupContent(8, "\r\n    Count: ");
            __builder.AddContent(9, 
#nullable restore
#line 10 "C:\Users\PC\source\repos\EmployeeManagement\EmployeeManagement\EmployeeManagement.Web\Pages\TextAreaBinding.razor"
            Description.Length

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591