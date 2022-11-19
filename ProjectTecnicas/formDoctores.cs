using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTecnicas
{
    public partial class Doctores : Form
    {
        public Doctores()
        {
            InitializeComponent();
        }

        private void Doctores_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.nombre = txtNombre.Text;
            doctor.apellido = txtApellido.Text;
            doctor.telefono = txtTelefono.Text;
            doctor.correo = txtCorreo.Text;
            doctor.especialidad = txtEspecialidad.Text;
            doctor.gradoAcademico = txtGradoAcademico.Text;
            doctor.estadoCivil = selectEstadoCivil.Text;
            doctor.tipo = "Doctor";

            int resultado = PacienteAgregar.agregarDoctor(doctor);


            if (resultado > 0)
            {
                MessageBox.Show("exito al guardar");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                txtEspecialidad.Text = "";
                txtGradoAcademico.Text = "";
                selectEstadoCivil.Text = "";
            }
            else
            {
                MessageBox.Show("No se puedo guardar");
            }

        }
    }
}
