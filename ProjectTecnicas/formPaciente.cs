namespace ProjectTecnicas
{
    public partial class formPaciente : Form
    {
        public formPaciente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.nombre = txtNombre.Text;
            paciente.apellido = txtApellido.Text;
            paciente.telefono = txtTelefono.Text;
            paciente.correo = txtCorreo.Text;
            paciente.estadoCivil = selectEstado.Text;
            paciente.patologia = checkPatologia.Checked;
            paciente.contrato = checkContrato.Checked;
            paciente.tipo = "Paciente";

            if (paciente.patologia && paciente.contrato)
            {
                paciente.activo = true;
            }

            int resultado = PacienteAgregar.agregarPaciente(paciente);

            if (resultado > 0)
            {
                MessageBox.Show("exito al guardar");
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtCorreo.Text = "";
                checkContrato.Checked = false;
                checkPatologia.Checked = false;
                selectEstado.Text = "";
            }
            else
            {
                MessageBox.Show("No se puedo guardar");
            }
        }
    }
}