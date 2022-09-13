using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CuidadoRemoto.Dominio;
using CuidadoRemoto.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace CuidadoRemoto.Frontend.Pages
{
   
    public class ListadoPropietariosModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario;
        public IEnumerable<PropietarioBovino> Propietarios { get; set; }
        public ListadoPropietariosModel()
        {
            this.repositorioPropietario= new RepositorioPropietario(new CuidadoRemoto.Persistencia.AppContext());
        }
        public void OnGet()
        {  //lLamado del metodo
            Propietarios= repositorioPropietario.GetAllPropietarios();
        }
    }
}
