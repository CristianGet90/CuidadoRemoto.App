using CuidadoRemoto.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace CuidadoRemoto.Persistencia
{
     public class RepositorioPropietario : IRepositorioPropietario
     {
          private readonly AppContext _appContext;
           // Defenir contexto solo lectura y se relaciona con Context para que tenga acceso a las obciones de DBCONTEXT
        //READ ONLY ES SOLO LECTURA NO SE PUEDE CAMBIAR

        public RepositorioBovino(AppContext appContext) //Contructor
        {
            _appContext=appContext;
        }
        Propietario IRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var bovinoAdicionado=_appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }
        void  IRepositorioPropietario.DeletePropietario(int Id)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p=>p.Id==idPropietario); //Encuentro con un ciclo for cuando variable p sea igual a id bovino
            if (propietarioEncontrado==null)
            {
                return; //termina la sentencia
            }
            _appContext.Propietarios.Remove(propietarioEncontrado); //Codigo para borrar el bovino encontrado
            _appContext.SaveChanges(); // Guardamos los datos
        }

        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios()
        {
            return _appContext.Propietarios; //Retorna toda la lista de bovinos en una tabla
        }
        Propietario IRepositorioPropietario.GetPropietario(int Id)
        {
            
            return _appContext.Propietarios.FirstOrDefault(p=>p.Id==idPrppietario);
        }

        Bovino IRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p=>p.Id==propietario.Id); //Encuentro con un ciclo for cuando variable p sea igual a id bovino
            if (propietarioEncontrado==null)
            {
                propietarioEncontrado.Cedula_Propietario=propietario.Cedula_Propietario;
                propietarioEncontrado.Nombres=propietario.Nombres;
                propietarioEncontrado.Apellidos=propietario.Apellidos;
                propietarioEncontrado.Direccion=propietario.Direccion;
                propietarioEncontrado.Telefono=propietario.Telefono;
                propietarioEncontrado.Correo=propietario.Correo;



                _appContext.SaveChanges();
                 
            }

            return propietarioEncontrado;

        }
        
    }
}
     
     
