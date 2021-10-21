using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class TextAreaBindingBase : ComponentBase
    {
        public string Description { get; set; } = string.Empty;
    }
}
