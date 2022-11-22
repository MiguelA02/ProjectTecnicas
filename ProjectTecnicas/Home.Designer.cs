namespace ProjectTecnicas
{
    partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.crearHopital = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 115);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Paciente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 115);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar doctores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOperacion
            // 
            this.btnOperacion.Location = new System.Drawing.Point(138, 266);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(205, 115);
            this.btnOperacion.TabIndex = 2;
            this.btnOperacion.Text = "Registrar Operacion";
            this.btnOperacion.UseVisualStyleBackColor = true;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // crearHopital
            // 
            this.crearHopital.Location = new System.Drawing.Point(423, 266);
            this.crearHopital.Name = "crearHopital";
            this.crearHopital.Size = new System.Drawing.Size(205, 115);
            this.crearHopital.TabIndex = 3;
            this.crearHopital.Text = "Agregar Hospital";
            this.crearHopital.UseVisualStyleBackColor = true;
            this.crearHopital.Click += new System.EventHandler(this.crearHopital_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 462);
            this.Controls.Add(this.crearHopital);
            this.Controls.Add(this.btnOperacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnOperacion;
        private Button crearHopital;
    }
}