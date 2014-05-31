namespace AgregarUsuarios
{
    partial class Modificar_Usuario
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.cmb_Lugares = new System.Windows.Forms.ComboBox();
            this.cmb_Ballenas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_NombreCuenta = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_RContraseña = new System.Windows.Forms.Label();
            this.txt_RepetirConstraseña = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.cmb_Titulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CambiarContraseña = new System.Windows.Forms.Button();
            this.chb_Activo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nombre";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(14, 156);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(106, 24);
            this.lbl_Usuario.TabIndex = 24;
            this.lbl_Usuario.Text = "Nick Name";
            // 
            // cmb_Lugares
            // 
            this.cmb_Lugares.Enabled = false;
            this.cmb_Lugares.FormattingEnabled = true;
            this.cmb_Lugares.Location = new System.Drawing.Point(484, 396);
            this.cmb_Lugares.Name = "cmb_Lugares";
            this.cmb_Lugares.Size = new System.Drawing.Size(300, 32);
            this.cmb_Lugares.TabIndex = 23;
            // 
            // cmb_Ballenas
            // 
            this.cmb_Ballenas.Enabled = false;
            this.cmb_Ballenas.FormattingEnabled = true;
            this.cmb_Ballenas.Location = new System.Drawing.Point(484, 336);
            this.cmb_Ballenas.Name = "cmb_Ballenas";
            this.cmb_Ballenas.Size = new System.Drawing.Size(300, 32);
            this.cmb_Ballenas.Sorted = true;
            this.cmb_Ballenas.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 391);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Lugar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Especie";
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(189, 294);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.ReadOnly = true;
            this.txt_Apellidos.Size = new System.Drawing.Size(300, 30);
            this.txt_Apellidos.TabIndex = 19;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(189, 235);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.ReadOnly = true;
            this.txt_Nombre.Size = new System.Drawing.Size(300, 30);
            this.txt_Nombre.TabIndex = 18;
            // 
            // txt_NombreCuenta
            // 
            this.txt_NombreCuenta.Location = new System.Drawing.Point(189, 150);
            this.txt_NombreCuenta.Name = "txt_NombreCuenta";
            this.txt_NombreCuenta.ReadOnly = true;
            this.txt_NombreCuenta.Size = new System.Drawing.Size(300, 30);
            this.txt_NombreCuenta.TabIndex = 17;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(195, 40);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 30);
            this.txt_Id.TabIndex = 15;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(68, 46);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(34, 24);
            this.lbl_ID.TabIndex = 27;
            this.lbl_ID.Text = "ID";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(384, 34);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(141, 36);
            this.btn_buscar.TabIndex = 28;
            this.btn_buscar.Text = "Seleccionar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(30, 491);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(101, 24);
            this.lbl_Contraseña.TabIndex = 30;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(205, 488);
            this.txt_Contraseña.MaxLength = 30;
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(300, 30);
            this.txt_Contraseña.TabIndex = 29;
            this.txt_Contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Contraseña_KeyPress);
            // 
            // lbl_RContraseña
            // 
            this.lbl_RContraseña.AutoSize = true;
            this.lbl_RContraseña.Location = new System.Drawing.Point(30, 545);
            this.lbl_RContraseña.Name = "lbl_RContraseña";
            this.lbl_RContraseña.Size = new System.Drawing.Size(169, 24);
            this.lbl_RContraseña.TabIndex = 32;
            this.lbl_RContraseña.Text = "Repetri Contraseña";
            this.lbl_RContraseña.Visible = false;
            // 
            // txt_RepetirConstraseña
            // 
            this.txt_RepetirConstraseña.Location = new System.Drawing.Point(205, 545);
            this.txt_RepetirConstraseña.Name = "txt_RepetirConstraseña";
            this.txt_RepetirConstraseña.ReadOnly = true;
            this.txt_RepetirConstraseña.Size = new System.Drawing.Size(300, 30);
            this.txt_RepetirConstraseña.TabIndex = 31;
            this.txt_RepetirConstraseña.Visible = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(710, 150);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(117, 78);
            this.btn_Modificar.TabIndex = 33;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // cmb_Titulo
            // 
            this.cmb_Titulo.Enabled = false;
            this.cmb_Titulo.FormattingEnabled = true;
            this.cmb_Titulo.Items.AddRange(new object[] {
            "-",
            "Dr.",
            "Dra.",
            "Ing.",
            "Lic.",
            "M.C.",
            "Mtra.",
            "Mtro.",
            "Prof.",
            "Profa."});
            this.cmb_Titulo.Location = new System.Drawing.Point(189, 193);
            this.cmb_Titulo.Name = "cmb_Titulo";
            this.cmb_Titulo.Size = new System.Drawing.Size(300, 32);
            this.cmb_Titulo.Sorted = true;
            this.cmb_Titulo.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Título";
            // 
            // btn_CambiarContraseña
            // 
            this.btn_CambiarContraseña.Enabled = false;
            this.btn_CambiarContraseña.Location = new System.Drawing.Point(529, 488);
            this.btn_CambiarContraseña.Name = "btn_CambiarContraseña";
            this.btn_CambiarContraseña.Size = new System.Drawing.Size(189, 78);
            this.btn_CambiarContraseña.TabIndex = 36;
            this.btn_CambiarContraseña.Text = "Cambiar Contraseña";
            this.btn_CambiarContraseña.UseVisualStyleBackColor = true;
            this.btn_CambiarContraseña.Click += new System.EventHandler(this.btn_CambiarContraseña_Click);
            // 
            // chb_Activo
            // 
            this.chb_Activo.AutoSize = true;
            this.chb_Activo.Location = new System.Drawing.Point(544, 156);
            this.chb_Activo.Name = "chb_Activo";
            this.chb_Activo.Size = new System.Drawing.Size(82, 28);
            this.chb_Activo.TabIndex = 37;
            this.chb_Activo.Text = "Activo";
            this.chb_Activo.UseVisualStyleBackColor = true;
            // 
            // Modificar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chb_Activo);
            this.Controls.Add(this.btn_CambiarContraseña);
            this.Controls.Add(this.cmb_Titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.lbl_RContraseña);
            this.Controls.Add(this.txt_RepetirConstraseña);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.cmb_Lugares);
            this.Controls.Add(this.cmb_Ballenas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_NombreCuenta);
            this.Controls.Add(this.txt_Id);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Modificar_Usuario";
            this.Size = new System.Drawing.Size(850, 630);
            this.Load += new System.EventHandler(this.Modificar_Usuario_Load);
            this.Enter += new System.EventHandler(this.Modificar_Usuario_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.ComboBox cmb_Lugares;
        private System.Windows.Forms.ComboBox cmb_Ballenas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_NombreCuenta;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label lbl_RContraseña;
        private System.Windows.Forms.TextBox txt_RepetirConstraseña;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.ComboBox cmb_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CambiarContraseña;
        private System.Windows.Forms.CheckBox chb_Activo;

    }
}
