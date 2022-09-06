using CuidadoRemoto.Dominio;
using System.Collections.Generic;

namespace CuidadoRemoto.Persistencia
{
    public interface IRepositorioBovino
    {
        IEnumerable <Bovino> GetAllBovinos();
        Bovino AddBovino(Bovino bovino);
        Bovino UpdateBovino(Bovino bovino);
        void DeleteBovino(int Id);
        Bovino GetBovino (int Id);

    }

}