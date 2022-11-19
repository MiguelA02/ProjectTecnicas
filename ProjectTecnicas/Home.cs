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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPaciente paciente = new formPaciente();
            paciente.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doctores doctores = new Doctores();
            doctores.Show();
            this.Visible = false;
        }
    }
}
