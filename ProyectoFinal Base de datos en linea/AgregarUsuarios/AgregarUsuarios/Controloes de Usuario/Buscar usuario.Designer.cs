namespace AgregarUsuarios
{
    partial class Buscar_usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.rbt_ID = new System.Windows.Forms.RadioButton();
            this.rbt_NoID = new System.Windows.Forms.RadioButton();
            this.USR = new System.Windows.Forms.TextBox();
            this.NOM = new System.Windows.Forms.TextBox();
            this.APLL = new System.Windows.Forms.TextBox();
            this.ID_REGION = new System.Windows.Forms.ComboBox();
            this.ID_ESPECIE = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btb_Buscar = new System.Windows.Forms.Button();
            this.TIT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos que conozca (y esté seguro del usuario)";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(80, 98);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 30);
            this.txt_Id.TabIndex = 1;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // rbt_ID
            // 
            this.rbt_ID.AutoSize = true;
            this.rbt_ID.Checked = true;
            this.rbt_ID.Location = new System.Drawing.Point(10, 61);
            this.rbt_ID.Name = "rbt_ID";
            this.rbt_ID.Size = new System.Drawing.Size(124, 28);
            this.rbt_ID.TabIndex = 2;
            this.rbt_ID.TabStop = true;
            this.rbt_ID.Text = "Conozco ID";
            this.rbt_ID.UseVisualStyleBackColor = true;
            // 
            // rbt_NoID
            // 
            this.rbt_NoID.AutoSize = true;
            this.rbt_NoID.Location = new System.Drawing.Point(10, 210);
            this.rbt_NoID.Name = "rbt_NoID";
            this.rbt_NoID.Size = new System.Drawing.Size(207, 28);
            this.rbt_NoID.TabIndex = 3;
            this.rbt_NoID.Text = "Buscar Coincidencias";
            this.rbt_NoID.UseVisualStyleBackColor = true;
            // 
            // USR
            // 
            this.USR.Location = new System.Drawing.Point(203, 259);
            this.USR.Name = "USR";
            this.USR.Size = new System.Drawing.Size(300, 30);
            this.USR.TabIndex = 4;
            // 
            // NOM
            // 
            this.NOM.Location = new System.Drawing.Point(203, 360);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(300, 30);
            this.NOM.TabIndex = 5;
            // 
            // APLL
            // 
            this.APLL.Location = new System.Drawing.Point(203, 419);
            this.APLL.Name = "APLL";
            this.APLL.Size = new System.Drawing.Size(300, 30);
            this.APLL.TabIndex = 6;
            // 
            // ID_REGION
            // 
            this.ID_REGION.FormattingEnabled = true;
            this.ID_REGION.Location = new System.Drawing.Point(203, 547);
            this.ID_REGION.Name = "ID_REGION";
            this.ID_REGION.Size = new System.Drawing.Size(300, 32);
            this.ID_REGION.TabIndex = 11;
            // 
            // ID_ESPECIE
            // 
            this.ID_ESPECIE.FormattingEnabled = true;
            this.ID_ESPECIE.Location = new System.Drawing.Point(203, 487);
            this.ID_ESPECIE.Name = "ID_ESPECIE";
            this.ID_ESPECIE.Size = new System.Drawing.Size(300, 32);
            this.ID_ESPECIE.Sorted = true;
            this.ID_ESPECIE.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 542);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lugar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 487);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Especie";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(76, 265);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(106, 24);
            this.lbl_Usuario.TabIndex = 12;
            this.lbl_Usuario.Text = "Nick Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Apellido";
            // 
            // btb_Buscar
            // 
            this.btb_Buscar.Location = new System.Drawing.Point(622, 114);
            this.btb_Buscar.Name = "btb_Buscar";
            this.btb_Buscar.Size = new System.Drawing.Size(197, 184);
            this.btb_Buscar.TabIndex = 15;
            this.btb_Buscar.Text = "Buscar";
            this.btb_Buscar.UseVisualStyleBackColor = true;
            this.btb_Buscar.Click += new System.EventHandler(this.btb_Buscar_Click);
            // 
            // TIT
            // 
            this.TIT.FormattingEnabled = true;
            this.TIT.Items.AddRange(new object[] {
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
            this.TIT.Location = new System.Drawing.Point(203, 311);
            this.TIT.Name = "TIT";
            this.TIT.Size = new System.Drawing.Size(104, 32);
            this.TIT.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Titulo";
            // 
            // Buscar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TIT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btb_Buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.ID_REGION);
            this.Controls.Add(this.ID_ESPECIE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.APLL);
            this.Controls.Add(this.NOM);
            this.Controls.Add(this.USR);
            this.Controls.Add(this.rbt_NoID);
            this.Controls.Add(this.rbt_ID);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Buscar_usuario";
            this.Size = new System.Drawing.Size(850, 630);
            this.Load += new System.EventHandler(this.Buscar_usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.RadioButton rbt_ID;
        private System.Windows.Forms.RadioButton rbt_NoID;
        private System.Windows.Forms.TextBox USR;
        private System.Windows.Forms.TextBox NOM;
        private System.Windows.Forms.TextBox APLL;
        private System.Windows.Forms.ComboBox ID_REGION;
        private System.Windows.Forms.ComboBox ID_ESPECIE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btb_Buscar;
        private System.Windows.Forms.ComboBox TIT;
        private System.Windows.Forms.Label label4;
    }
}
