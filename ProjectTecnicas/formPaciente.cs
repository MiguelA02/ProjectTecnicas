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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite números", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            } 
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}