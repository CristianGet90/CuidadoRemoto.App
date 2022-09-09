using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuidadoRemoto.Frontend
{
    public class FormVeterinarioModel : PageModel
    {
       private string[] Veterinarios = { "Datos del Veterinario" };

        public List<string> ListaDatosVeterinario { get; set; }

        public void OnGet()
        {
            ListaDatosVeterinario= new List<string>();
            ListaDatosVeterinario.AddRange(Veterinarios);
        }
    }
}
