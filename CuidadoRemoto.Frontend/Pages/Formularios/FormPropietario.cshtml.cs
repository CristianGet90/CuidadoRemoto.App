using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuidadoRemoto.Frontend
{
    public class FormPropietarioModel : PageModel
    {
        private string[] Propietarios = { "Datos del Propietario" };

        public List<string> ListaDatosPropietario { get; set; }

        public void OnGet()
        {
            ListaDatosPropietario = new List<string>();
            ListaDatosPropietario.AddRange(Propietarios);
        }
    }

}

