using CuidadoRemoto.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace CuidadoRemoto.Persistencia
{
     public class RepositorioBovino : IRepositorioBovino
     {
          private readonly AppContext _appContext;
           // Defenir contexto solo lectura y se relaciona con Context para que tenga acceso a las obciones de DBCONTEXT
        //READ ONLY ES SOLO LECTURA NO SE PUEDE CAMBIAR

        public RepositorioBovino(AppContext appContext) //Contructor
        {
            _appContext=appContext;
        }
        Bovino IRepositorioBovino.AddBovino(Bovino bovino)
        {
            var bovinoAdicionado=_appContext.Bovinos.Add(bovino);
            _appContext.SaveChanges();
            return bovinoAdicionado.Entity;
        }
        void  IRepositorioBovino.DeleteBovino(int idBovino)
        {
            var bovinoEncontrado = _appContext.Bovinos.FirstOrDefault(p=>p.Id==idBovino); //Encuentro con un ciclo for cuando variable p sea igual a id bovino
            if (bovinoEncontrado==null)
            {
                return; //termina la sentencia
            }
            _appContext.Bovinos.Remove(bovinoEncontrado); //Codigo para borrar el bovino encontrado
            _appContext.SaveChanges(); // Guardamos los datos
        }

        IEnumerable<Bovino> IRepositorioBovino.GetAllBovinos()
        {
            return _appContext.Bovinos; //Retorna toda la lista de bovinos en una tabla
        }
        Bovino IRepositorioBovino.Getbovino(int idBovino)
        {
            
            return _appContext.Bovinos.FirstOrDefault(p=>p.Id==idBovino);
        }

        Bovino IRepositorioBovino.UpdateBovino(Bovino bovino)
        {
            var bovinoEncontrado = _appContext.Bovinos.FirstOrDefault(p=>p.Id==bovino.Id); //Encuentro con un ciclo for cuando variable p sea igual a id bovino
            if (bovinoEncontrado==null)
            {
                bovinoEncontrado.Nombre=bovino.Nombre;
                bovinoEncontrado.Color=bovino.Color;


                _appContext.SaveChanges();
                 
            }

            return bovinoEncontrado;

        }
        
    }
}
     
     

