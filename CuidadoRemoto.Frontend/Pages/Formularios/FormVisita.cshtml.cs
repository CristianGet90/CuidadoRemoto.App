using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CuidadoRemoto.Frontend
{
    public class FormVisitaModel : PageModel
    {
        private string[] Visitas = { "Datos de la visita" };

        public List<string> ListaDatosVisita { get; set; }

        public void OnGet()
        {
            ListaDatosVisita= new List<string>();
            ListaDatosVisita.AddRange(Visitas);
        }
    }
}
