using CuidadoRemoto.Dominio;
using System.Collections.Generic;

namespace CuidadoRemoto.Persistencia
{
    public interface IRepositorioPropietario
    {
        IEnumerable <Propietario> GetAllPropietarios();
        Propietario AddPropietario (Propietario propietario);
        Propietario UpdatePropietario (Propietario propietario);
        void DeletePropietario (int Id);
        Propietario GetPropietario (int Id);

    }

}