namespace ProyectoBallenas
{
    partial class Carga
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btn_Especies = new System.Windows.Forms.Button();
            this.btn_Regiones = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvendio. La base de datos no cuenta aun con los datos suficientes para empezar" +
    ". Por favor designe a un administrador, agrege minimo una especie de ballena y u" +
    "na región.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.btn_Usuarios.Location = new System.Drawing.Point(174, 197);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(115, 37);
            this.btn_Usuarios.TabIndex = 1;
            this.btn_Usuarios.Text = "Usuario";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click);
            // 
            // btn_Especies
            // 
            this.btn_Especies.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.btn_Especies.Location = new System.Drawing.Point(318, 197);
            this.btn_Especies.Name = "btn_Especies";
            this.btn_Especies.Size = new System.Drawing.Size(115, 37);
            this.btn_Especies.TabIndex = 2;
            this.btn_Especies.Text = "Especies";
            this.btn_Especies.UseVisualStyleBackColor = true;
            this.btn_Especies.Click += new System.EventHandler(this.btn_Especies_Click);
            // 
            // btn_Regiones
            // 
            this.btn_Regiones.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.btn_Regiones.Location = new System.Drawing.Point(453, 196);
            this.btn_Regiones.Name = "btn_Regiones";
            this.btn_Regiones.Size = new System.Drawing.Size(115, 37);
            this.btn_Regiones.TabIndex = 3;
            this.btn_Regiones.Text = "Regionones";
            this.btn_Regiones.UseVisualStyleBackColor = true;
            this.btn_Regiones.Click += new System.EventHandler(this.btn_Regiones_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.button1.Location = new System.Drawing.Point(604, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Listo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoBallenas.Properties.Resources.blue_whale;
            this.ClientSize = new System.Drawing.Size(740, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Regiones);
            this.Controls.Add(this.btn_Especies);
            this.Controls.Add(this.btn_Usuarios);
            this.Controls.Add(this.label1);
            this.Name = "Carga";
            this.Text = "Carga";
            this.Load += new System.EventHandler(this.Carga_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.Button btn_Especies;
        private System.Windows.Forms.Button btn_Regiones;
        private System.Windows.Forms.Button button1;
    }
}