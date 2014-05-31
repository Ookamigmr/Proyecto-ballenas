namespace AgregarEspecies
{
    partial class frm_Especies
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
            this.spc_Menu = new System.Windows.Forms.SplitContainer();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Menu)).BeginInit();
            this.spc_Menu.Panel1.SuspendLayout();
            this.spc_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // spc_Menu
            // 
            this.spc_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Menu.Location = new System.Drawing.Point(0, 0);
            this.spc_Menu.Name = "spc_Menu";
            // 
            // spc_Menu.Panel1
            // 
            this.spc_Menu.Panel1.Controls.Add(this.btn_Modificar);
            this.spc_Menu.Panel1.Controls.Add(this.btn_Agregar);
            this.spc_Menu.Size = new System.Drawing.Size(878, 420);
            this.spc_Menu.SplitterDistance = 162;
            this.spc_Menu.TabIndex = 0;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(12, 187);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(142, 56);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(12, 127);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(142, 54);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // frm_Especies
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(878, 420);
            this.Controls.Add(this.spc_Menu);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.Name = "frm_Especies";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Especies_Load);
            this.spc_Menu.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Menu)).EndInit();
            this.spc_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spc_Menu;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
    }
}

