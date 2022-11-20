using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        public static int agregarOperacion(Operacion operacion)
        {
            using (SqlConnection conexion = BDconexion.obtenerConexion())
            {
                string query = "insert into Operacion (idPaciente, idDoctor, idHospital, codigoCotrato, valorContrato, descripcion) values('" + operacion.idPaciente + "', '" + operacion.idDoctor + "', " + operacion.idHospital + ", '" + operacion.codigoContrato + "', '" + operacion.valorContrato + "', '" + operacion.descripcion + "')";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
            return 1;
        }

        public static SqlDataReader traerInformacionDB(string tipo, string consulta)
        {
            SqlConnection conexion = BDconexion.obtenerConexion();
            string query = "select "+consulta+" from Personas  where tipo = '"+ tipo +"';";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader renderPacientes = comando.ExecuteReader();
            return renderPacientes;
        }
        public static int generadorDeNumerosRandoms()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);
            return numero;
        }
    }


}
