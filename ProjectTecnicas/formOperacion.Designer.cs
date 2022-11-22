namespace ProjectTecnicas
{
    partial class formOperacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectHospital = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectPaciente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectDoctor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValorContrato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectHospital
            // 
            this.selectHospital.AllowDrop = true;
            this.selectHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectHospital.FormattingEnabled = true;
            this.selectHospital.Location = new System.Drawing.Point(36, 76);
            this.selectHospital.Name = "selectHospital";
            this.selectHospital.Size = new System.Drawing.Size(151, 23);
            this.selectHospital.TabIndex = 0;
            this.selectHospital.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paciente";
            // 
            // selectPaciente
            // 
            this.selectPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPaciente.FormattingEnabled = true;
            this.selectPaciente.Location = new System.Drawing.Point(36, 119);
            this.selectPaciente.Name = "selectPaciente";
            this.selectPaciente.Size = new System.Drawing.Size(151, 23);
            this.selectPaciente.TabIndex = 2;
            this.selectPaciente.SelectedIndexChanged += new System.EventHandler(this.selectPaciente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doctor";
            // 
            // selectDoctor
            // 
            this.selectDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDoctor.FormattingEnabled = true;
            this.selectDoctor.Location = new System.Drawing.Point(36, 165);
            this.selectDoctor.Name = "selectDoctor";
            this.selectDoctor.Size = new System.Drawing.Size(151, 23);
            this.selectDoctor.TabIndex = 4;
            this.selectDoctor.SelectedIndexChanged += new System.EventHandler(this.selectDoctor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(36, 252);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(293, 91);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.Descripcion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripcion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Registrar Operacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValorContrato
            // 
            this.txtValorContrato.Location = new System.Drawing.Point(36, 208);
            this.txtValorContrato.Name = "txtValorContrato";
            this.txtValorContrato.Size = new System.Drawing.Size(151, 23);
            this.txtValorContrato.TabIndex = 10;
            this.txtValorContrato.TextChanged += new System.EventHandler(this.valorContrato_TextChanged);
            this.txtValorContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorContrato_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor Contrato";
            // 
            // formOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(572, 462);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorContrato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectDoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectHospital);
            this.Name = "formOperacion";
            this.Text = "formOperacion";
            this.Load += new System.EventHandler(this.formOperacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox selectHospital;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox selectDoctor;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label5;
        private Button button1;
        private TextBox txtValorContrato;
        private Label label6;
        public ComboBox selectPaciente;
    }
}