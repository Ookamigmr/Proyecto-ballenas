namespace AgregarUsuarios
{
    partial class Usuarios_Encontrados
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
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.ID_REGION = new System.Windows.Forms.ComboBox();
            this.ID_ESPECIE = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(18, 94);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(805, 405);
            this.dgv_usuarios.TabIndex = 1;
            this.dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_usuarios_CellContentClick);
            this.dgv_usuarios.DoubleClick += new System.EventHandler(this.MostrarDUSR);
            // 
            // ID_REGION
            // 
            this.ID_REGION.FormattingEnabled = true;
            this.ID_REGION.Location = new System.Drawing.Point(345, 580);
            this.ID_REGION.Name = "ID_REGION";
            this.ID_REGION.Size = new System.Drawing.Size(300, 32);
            this.ID_REGION.TabIndex = 13;
            this.ID_REGION.Visible = false;
            // 
            // ID_ESPECIE
            // 
            this.ID_ESPECIE.FormattingEnabled = true;
            this.ID_ESPECIE.Location = new System.Drawing.Point(345, 520);
            this.ID_ESPECIE.Name = "ID_ESPECIE";
            this.ID_ESPECIE.Size = new System.Drawing.Size(300, 32);
            this.ID_ESPECIE.Sorted = true;
            this.ID_ESPECIE.TabIndex = 12;
            this.ID_ESPECIE.Visible = false;
            // 
            // Usuarios_Encontrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ID_REGION);
            this.Controls.Add(this.ID_ESPECIE);
            this.Controls.Add(this.dgv_usuarios);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Usuarios_Encontrados";
            this.Size = new System.Drawing.Size(850, 630);
            this.Load += new System.EventHandler(this.Usuarios_Encontrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.ComboBox ID_REGION;
        private System.Windows.Forms.ComboBox ID_ESPECIE;
    }
}
