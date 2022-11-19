using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTecnicas
{
    public class Doctor
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string especialidad { get; set; }
        public string gradoAcademico { get; set; }
        public string estadoCivil { get; set; }
        public string tipo { get; set; }

        public Doctor() { }
        public Doctor(string nombre, string apellido, string telefono, string correo, string especialidad, string gradoAcademico, string estadoCivil)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.correo = correo;
            this.especialidad = especialidad;
            this.gradoAcademico = gradoAcademico;
            this.estadoCivil = estadoCivil;
        }
    }
}
