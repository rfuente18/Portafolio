using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portafolio.Pages
{
    public class ProyectosModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Your contact page.";
        }
    }
}