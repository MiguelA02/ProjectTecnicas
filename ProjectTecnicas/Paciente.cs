using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTecnicas
{
    public class Paciente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string estadoCivil { get; set; }
        public bool patologia { get; set; }
        public bool contrato { get; set; }
        public bool activo { get; set; }
        public string tipo { get; set; }    
        public Paciente() { }

        public Paciente(string nombre, string apellido, string telefono, string correo, string estadoCivil, bool patologia, bool contrato, bool activo , string tipo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.correo = correo;
            this.estadoCivil = estadoCivil;
            this.patologia  = patologia;
            this.contrato = contrato;
            this.tipo = tipo;

        }
    }
}
