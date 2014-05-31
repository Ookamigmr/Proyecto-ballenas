namespace AgregarUsuarios
{
    partial class DatosInvestigador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ConfirmaciónContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.cmb_titulo = new System.Windows.Forms.ComboBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NombreInvestigador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ConfirmaciónContraseña);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Contraseña);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_NombreUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(553, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // txt_ConfirmaciónContraseña
            // 
            this.txt_ConfirmaciónContraseña.Enabled = false;
            this.txt_ConfirmaciónContraseña.Location = new System.Drawing.Point(215, 171);
            this.txt_ConfirmaciónContraseña.MaxLength = 15;
            this.txt_ConfirmaciónContraseña.Name = "txt_ConfirmaciónContraseña";
            this.txt_ConfirmaciónContraseña.Size = new System.Drawing.Size(191, 30);
            this.txt_ConfirmaciónContraseña.TabIndex = 5;
            this.txt_ConfirmaciónContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ConfirmaciónContraseña_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repetir Constraseña";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Enabled = false;
            this.txt_Contraseña.Location = new System.Drawing.Point(215, 127);
            this.txt_Contraseña.MaxLength = 15;
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(191, 30);
            this.txt_Contraseña.TabIndex = 3;
            this.txt_Contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Contraseña_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.Location = new System.Drawing.Point(215, 71);
            this.txt_NombreUsuario.MaxLength = 20;
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(191, 30);
            this.txt_NombreUsuario.TabIndex = 1;
            this.txt_NombreUsuario.TextChanged += new System.EventHandler(this.txt_NombreUsuario_TextChanged);
            this.txt_NombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombe de Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Continuar);
            this.groupBox2.Controls.Add(this.cmb_titulo);
            this.groupBox2.Controls.Add(this.txt_Apellidos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_NombreInvestigador);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(0, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(553, 337);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Investigador";
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Location = new System.Drawing.Point(396, 274);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(108, 41);
            this.btn_Continuar.TabIndex = 7;
            this.btn_Continuar.Text = "Continuar";
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_Continuar_Click);
            // 
            // cmb_titulo
            // 
            this.cmb_titulo.Enabled = false;
            this.cmb_titulo.FormattingEnabled = true;
            this.cmb_titulo.Items.AddRange(new object[] {
            "-",
            "Dr.",
            "Ing.",
            "Lic.",
            "M.C.",
            "Mtra.",
            "Mtro.",
            "Prof.",
            "Profa."});
            this.cmb_titulo.Location = new System.Drawing.Point(215, 71);
            this.cmb_titulo.Name = "cmb_titulo";
            this.cmb_titulo.Size = new System.Drawing.Size(121, 32);
            this.cmb_titulo.Sorted = true;
            this.cmb_titulo.TabIndex = 6;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Enabled = false;
            this.txt_Apellidos.Location = new System.Drawing.Point(215, 171);
            this.txt_Apellidos.MaxLength = 15;
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(191, 30);
            this.txt_Apellidos.TabIndex = 5;
            this.txt_Apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellidos_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellidos";
            // 
            // txt_NombreInvestigador
            // 
            this.txt_NombreInvestigador.Enabled = false;
            this.txt_NombreInvestigador.Location = new System.Drawing.Point(215, 127);
            this.txt_NombreInvestigador.MaxLength = 15;
            this.txt_NombreInvestigador.Name = "txt_NombreInvestigador";
            this.txt_NombreInvestigador.Size = new System.Drawing.Size(191, 30);
            this.txt_NombreInvestigador.TabIndex = 3;
            this.txt_NombreInvestigador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreInvestigador_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Título";
            // 
            // DatosInvestigador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DatosInvestigador";
            this.Size = new System.Drawing.Size(553, 624);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ConfirmaciónContraseña;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_titulo;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NombreInvestigador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Continuar;
    }
}
