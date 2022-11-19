using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTecnicas
{
    public class PacienteAgregar
    {
        public static int agregarPaciente(Paciente paciente)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDconexion.obtenerConexion()) 
            {
                string query = "insert into Personas (nombre, apellido, telefono, correo, estadoCivil,activo, tipo) values('" + paciente.nombre + "', '" + paciente.apellido + "', " + paciente.telefono + ", '" + paciente.correo + "', '" + paciente.estadoCivil + "', '" + paciente.activo + "', '"+paciente.tipo+"')";
                SqlCommand comando = new SqlCommand(query,conexion);
                comando.ExecuteNonQuery();
            }
            return 1;
        }

        public static int agregarDoctor(Doctor doctor)
        {
            using (SqlConnection conexion = BDconexion.obtenerConexion())
            {
                string query = "insert into Personas (nombre, apellido, telefono,correo,especialidad,gradoAcademico,estadoCivil,tipo) values('" + doctor.nombre + "', '" + doctor.apellido + "', '" + doctor.telefono + "', '" + doctor.correo + "','" + doctor.especialidad + "', '" + doctor.gradoAcademico + "','" + doctor.estadoCivil + "', '" + doctor.tipo + "')";
                SqlCommand comando = new SqlCommand(query,conexion);
                comando.ExecuteNonQuery();
            }
            return 1;
        }
    }


}
