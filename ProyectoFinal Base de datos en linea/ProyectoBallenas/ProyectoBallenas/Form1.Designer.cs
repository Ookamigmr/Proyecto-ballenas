namespace ProyectoBallenas
{
    partial class PantallaInicio
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
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.cmx_Usuario = new System.Windows.Forms.ComboBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Especies = new System.Windows.Forms.Button();
            this.btn_Regiones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Enabled = false;
            this.btn_Usuarios.Location = new System.Drawing.Point(80, 296);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(187, 68);
            this.btn_Usuarios.TabIndex = 0;
            this.btn_Usuarios.Text = "Ir a Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Enabled = false;
            this.btn_Ingresar.Location = new System.Drawing.Point(496, 137);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(187, 68);
            this.btn_Ingresar.TabIndex = 1;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmx_Usuario
            // 
            this.cmx_Usuario.FormattingEnabled = true;
            this.cmx_Usuario.Location = new System.Drawing.Point(80, 137);
            this.cmx_Usuario.Name = "cmx_Usuario";
            this.cmx_Usuario.Size = new System.Drawing.Size(264, 32);
            this.cmx_Usuario.TabIndex = 2;
            this.cmx_Usuario.SelectedIndexChanged += new System.EventHandler(this.cmx_Usuario_SelectedIndexChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(80, 175);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '♠';
            this.txt_contraseña.Size = new System.Drawing.Size(264, 30);
            this.txt_contraseña.TabIndex = 3;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Location = new System.Drawing.Point(350, 137);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(106, 32);
            this.btn_Entrar.TabIndex = 4;
            this.btn_Entrar.Text = "Entrar →";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Especies
            // 
            this.btn_Especies.Enabled = false;
            this.btn_Especies.Location = new System.Drawing.Point(273, 296);
            this.btn_Especies.Name = "btn_Especies";
            this.btn_Especies.Size = new System.Drawing.Size(187, 68);
            this.btn_Especies.TabIndex = 5;
            this.btn_Especies.Text = "Ir a Especies";
            this.btn_Especies.UseVisualStyleBackColor = true;
            this.btn_Especies.Click += new System.EventHandler(this.btn_Especies_Click);
            // 
            // btn_Regiones
            // 
            this.btn_Regiones.Enabled = false;
            this.btn_Regiones.Location = new System.Drawing.Point(466, 296);
            this.btn_Regiones.Name = "btn_Regiones";
            this.btn_Regiones.Size = new System.Drawing.Size(187, 68);
            this.btn_Regiones.TabIndex = 6;
            this.btn_Regiones.Text = "Ir a Regiones";
            this.btn_Regiones.UseVisualStyleBackColor = true;
            this.btn_Regiones.Click += new System.EventHandler(this.btn_Regiones_Click);
            // 
            // PantallaInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ProyectoBallenas.Properties.Resources.blue_whale;
            this.ClientSize = new System.Drawing.Size(866, 457);
            this.Controls.Add(this.btn_Regiones);
            this.Controls.Add(this.btn_Especies);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.cmx_Usuario);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.btn_Usuarios);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.Name = "PantallaInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.ComboBox cmx_Usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Especies;
        private System.Windows.Forms.Button btn_Regiones;
    }
}

