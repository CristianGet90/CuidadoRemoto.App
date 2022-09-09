using System;
namespace CuidadoRemoto.Dominio
{
    public class Bovino
    {
        public int Id { get; set;}
        public int Codigo_Bovino { get; set;}
        public string Nombre {get; set;} 
        public string Color {get; set;}
        public string Especie {get; set;}
        public string Raza {get; set;}
        public int Edad {get;set;}
        public string idPropietario {get; set;}
        public string idVeterinario {get; set;}


    }
}