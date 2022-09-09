using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuidadoRemoto.Frontend
{
    public class FormBovinoModel : PageModel
    {
        private string[] Bovinos = { "Datos del Bovino" };

        public List<string> ListaDatosBovinos { get; set; }

        public void OnGet()
        {
            ListaDatosBovinos = new List<string>();
            ListaDatosBovinos.AddRange(Bovinos);
        }

    }
}
