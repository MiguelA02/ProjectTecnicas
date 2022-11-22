using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public static int agregarOperacion(Operacion operacion )
        {
            using (SqlConnection conexion = BDconexion.obtenerConexion())
            {
                string query = "insert into Operacion (idPaciente, idDoctor, idHospital, codigoCotrato, valorContrato, descripcion) values('" + operacion.idPaciente + "', '" + operacion.idDoctor + "', " + operacion.idHospital + ", '" + operacion.codigoContrato + "', '" + operacion.valorContrato + "', '" + operacion.descripcion + "')";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
            return 1;
        }
        public static int agregarHospital(Hospital hospital)
        {
            using(SqlConnection conexion = BDconexion.obtenerConexion())
            {
                string query = "INSERT Into Hospital(valorFiscal,areaTerreno,direccionExacta,provincia,canton,distrito,cantidadNiveles,color,cantidadConsultorios,tiposdCirugia,anoConstruccion,imagen )values('" + hospital.valorFiscal + "','" + hospital.areaTerreno + "','" + hospital.direccionExacta + "','" + hospital.provincia + "','" + hospital.canton + "','" + hospital.distrito + "','" + hospital.cantidadNiveles + "','" + hospital.color + "','" + hospital.cantidadConsultorios + "','" + hospital.tiposdCirugia + "','" + hospital.anoConstruccion + "','" + hospital.imagen + "')";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
            return 1;
        }

        public static SqlDataReader traerInformacionDB(string columnas, string tabla, string filtrar, string dato)
        {
            if (filtrar == null && dato == null)
            {
                SqlConnection conexion = BDconexion.obtenerConexion();
                string query = "select " + columnas + " from " + tabla + ";";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader renderPacientes = comando.ExecuteReader();
                return renderPacientes;
            }
            else
            {
                SqlConnection conexion = BDconexion.obtenerConexion();
                string query = "select " + columnas + " from " + tabla + "  where " + filtrar + " = '" + dato + "';";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader renderPacientes = comando.ExecuteReader();
                return renderPacientes;
            }
            
        }

        public static SqlDataReader traerInformacionDBDobleFiltro(string columnas, string tabla, string filtrar1, string dato1, string filtrar2, string dato2)
        {
            SqlConnection conexion = BDconexion.obtenerConexion();
            string query = "select " + columnas + " from " + tabla + "  where " + filtrar1 + " = '" + dato1 + "' AND " +filtrar2+ "= '" + dato2 + "';";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader renderDoctores = comando.ExecuteReader();
            return renderDoctores;
        }

        public static int generadorDeNumerosRandoms()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);
            return numero;
        }
        
    }


}
