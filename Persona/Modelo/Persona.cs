using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Modelo
{
    public class Persona
    {
        private string documento;
        private string nombres;
        private string apellidos;
        private string celular;
        private DateTime fechaNac;
        private string estatura;
        private string peso;

        public Persona ()
        { }
        public Persona(string documento, string nombres, string apellidos, string celular, DateTime fechaNac, string estatura, string peso)
        {
            this.documento = documento;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.celular = celular;
            this.fechaNac = fechaNac;
            this.estatura = estatura;
            this.peso = peso;
        }

        public string Documento { get => documento; set => documento = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Celular { get => celular; set => celular = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Estatura { get => estatura; set => estatura = value; }
        public string Peso { get => peso; set => peso = value; }
    }
}
