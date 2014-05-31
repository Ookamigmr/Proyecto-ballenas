namespace AgregarUsuarios
{
    partial class NuevoUsuario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sc_NuevoUsuario = new System.Windows.Forms.SplitContainer();
            this.chb_DatosInvestigación = new System.Windows.Forms.CheckBox();
            this.chb_DatosCuenta = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc_NuevoUsuario)).BeginInit();
            this.sc_NuevoUsuario.Panel1.SuspendLayout();
            this.sc_NuevoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_NuevoUsuario
            // 
            this.sc_NuevoUsuario.Location = new System.Drawing.Point(0, 0);
            this.sc_NuevoUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.sc_NuevoUsuario.Name = "sc_NuevoUsuario";
            // 
            // sc_NuevoUsuario.Panel1
            // 
            this.sc_NuevoUsuario.Panel1.Controls.Add(this.chb_DatosInvestigación);
            this.sc_NuevoUsuario.Panel1.Controls.Add(this.chb_DatosCuenta);
            this.sc_NuevoUsuario.Size = new System.Drawing.Size(850, 630);
            this.sc_NuevoUsuario.SplitterDistance = 283;
            this.sc_NuevoUsuario.SplitterWidth = 8;
            this.sc_NuevoUsuario.TabIndex = 2;
            // 
            // chb_DatosInvestigación
            // 
            this.chb_DatosInvestigación.AutoSize = true;
            this.chb_DatosInvestigación.Location = new System.Drawing.Point(23, 236);
            this.chb_DatosInvestigación.Margin = new System.Windows.Forms.Padding(6);
            this.chb_DatosInvestigación.Name = "chb_DatosInvestigación";
            this.chb_DatosInvestigación.Size = new System.Drawing.Size(186, 28);
            this.chb_DatosInvestigación.TabIndex = 1;
            this.chb_DatosInvestigación.Text = "Seleccionar especie";
            this.chb_DatosInvestigación.UseVisualStyleBackColor = true;
            this.chb_DatosInvestigación.CheckedChanged += new System.EventHandler(this.chb_DatosInvestigación_CheckedChanged);
            // 
            // chb_DatosCuenta
            // 
            this.chb_DatosCuenta.AutoSize = true;
            this.chb_DatosCuenta.Checked = true;
            this.chb_DatosCuenta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_DatosCuenta.Location = new System.Drawing.Point(23, 137);
            this.chb_DatosCuenta.Margin = new System.Windows.Forms.Padding(6);
            this.chb_DatosCuenta.Name = "chb_DatosCuenta";
            this.chb_DatosCuenta.Size = new System.Drawing.Size(214, 28);
            this.chb_DatosCuenta.TabIndex = 0;
            this.chb_DatosCuenta.Text = "Datos del investigador";
            this.chb_DatosCuenta.UseVisualStyleBackColor = true;
            this.chb_DatosCuenta.CheckedChanged += new System.EventHandler(this.chb_DatosCuenta_CheckedChanged);
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sc_NuevoUsuario);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NuevoUsuario";
            this.Size = new System.Drawing.Size(850, 630);
            this.sc_NuevoUsuario.Panel1.ResumeLayout(false);
            this.sc_NuevoUsuario.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_NuevoUsuario)).EndInit();
            this.sc_NuevoUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_DatosInvestigación;
        private System.Windows.Forms.CheckBox chb_DatosCuenta;
        public System.Windows.Forms.SplitContainer sc_NuevoUsuario;
    }
}
