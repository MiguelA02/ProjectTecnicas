using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTecnicas
{
    public class Operacion
    {
        public int idPaciente { get; set; }
        public int idDoctor { get; set; }
        public int idHospital { get; set; }
        public string codigoContrato { get; set; }
        public double valorContrato { get; set; }
        public string descripcion { get; set; }

        public Operacion(){ }
        public Operacion(int idPaciente, int idDoctor, int idHospital, string codigoContrato, double valorContrato, string descripcion)
        {
            this.idPaciente = idPaciente;
            this.idDoctor = idDoctor;
            this.idHospital = idHospital;
            this.codigoContrato= codigoContrato;
            this.valorContrato= valorContrato;
            this.descripcion= descripcion;
        }
    }
}
