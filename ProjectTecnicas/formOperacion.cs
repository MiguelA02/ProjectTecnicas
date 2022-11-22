using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTecnicas
{
    public partial class formOperacion : Form
    {
        public formOperacion()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void formOperacion_Load(object sender, EventArgs e)
        {

            SqlDataReader pacienteRender = PacienteAgregar.traerInformacionDB("nombre, id, apellido", "Personas", "tipo", "Paciente");
                while (pacienteRender.Read())
                {
                    selectPaciente.Items.Add(pacienteRender["id"].ToString()+ "-" + pacienteRender["nombre"].ToString() + " " + pacienteRender["apellido"].ToString());
                }
            SqlDataReader hospitalRender = PacienteAgregar.traerInformacionDB("id", "Hospital", null, null);
            while (hospitalRender.Read())
            {
                selectHospital.Items.Add(hospitalRender["id"]);
            }

            SqlDataReader doctoresRender = PacienteAgregar.traerInformacionDBDobleFiltro("nombre, id, apellido", "Personas", "tipo", "Doctor", "especialidad", "Cirujano");
                while (doctoresRender.Read())
                {
                    selectDoctor.Items.Add(doctoresRender["id"].ToString() + "-" + doctoresRender["nombre"].ToString() +" "+ doctoresRender["apellido"].ToString());
                }

        }

        public void selectPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void selectDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
            operacion.idPaciente = Convert.ToInt32(selectPaciente.Text.Split("-")[0]);
            operacion.idDoctor = Convert.ToInt32(selectDoctor.Text.Split("-")[0]);
            //aqui va hopital
            operacion.codigoContrato = "CIR" + PacienteAgregar.generadorDeNumerosRandoms();
            operacion.valorContrato = Convert.ToDouble(txtValorContrato.Text);
            operacion.descripcion = txtDescripcion.Text;
            int resultado = PacienteAgregar.agregarOperacion(operacion);

            if (resultado > 0)
            {
                MessageBox.Show("Operacion Registrada");
                selectPaciente.Text = "";
                selectDoctor.Text = "";
                selectHospital.Text = "";
                txtValorContrato.Text = "";
                txtDescripcion.Text = "";
            }
            else 
            {
                MessageBox.Show("Ha ocurrido un error");
            }

        }

        private void valorContrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
           
        }
    }
}
