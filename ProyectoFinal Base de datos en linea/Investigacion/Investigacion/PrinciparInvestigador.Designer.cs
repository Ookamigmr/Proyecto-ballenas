namespace Grupos
{
    partial class frm_Investigación
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Especie = new System.Windows.Forms.Label();
            this.lbl_Region = new System.Windows.Forms.Label();
            this.gbx_Datos = new System.Windows.Forms.GroupBox();
            this.pnl_Visualizar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbx_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especie:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zona:";
            // 
            // lbl_Especie
            // 
            this.lbl_Especie.AutoSize = true;
            this.lbl_Especie.Location = new System.Drawing.Point(131, 47);
            this.lbl_Especie.Name = "lbl_Especie";
            this.lbl_Especie.Size = new System.Drawing.Size(0, 29);
            this.lbl_Especie.TabIndex = 2;
            // 
            // lbl_Region
            // 
            this.lbl_Region.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Region.AutoSize = true;
            this.lbl_Region.Location = new System.Drawing.Point(707, 47);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(74, 29);
            this.lbl_Region.TabIndex = 3;
            this.lbl_Region.Text = "label4";
            // 
            // gbx_Datos
            // 
            this.gbx_Datos.Controls.Add(this.label1);
            this.gbx_Datos.Controls.Add(this.lbl_Region);
            this.gbx_Datos.Controls.Add(this.label2);
            this.gbx_Datos.Controls.Add(this.lbl_Especie);
            this.gbx_Datos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbx_Datos.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Datos.Location = new System.Drawing.Point(0, 0);
            this.gbx_Datos.Name = "gbx_Datos";
            this.gbx_Datos.Size = new System.Drawing.Size(1210, 90);
            this.gbx_Datos.TabIndex = 4;
            this.gbx_Datos.TabStop = false;
            this.gbx_Datos.Text = "Datos de la Investigación";
            // 
            // pnl_Visualizar
            // 
            this.pnl_Visualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_Visualizar.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_Visualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_Visualizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Visualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Visualizar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Visualizar.Location = new System.Drawing.Point(310, 90);
            this.pnl_Visualizar.Name = "pnl_Visualizar";
            this.pnl_Visualizar.Size = new System.Drawing.Size(900, 472);
            this.pnl_Visualizar.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Poblaciones";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Grupos.Properties.Resources.Ballena;
            this.pictureBox1.Location = new System.Drawing.Point(26, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 168);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Investigación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_Visualizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbx_Datos);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_Investigación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Investigación_Load);
            this.gbx_Datos.ResumeLayout(false);
            this.gbx_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Especie;
        private System.Windows.Forms.Label lbl_Region;
        private System.Windows.Forms.GroupBox gbx_Datos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_Visualizar;
        private System.Windows.Forms.Button button1;
    }
}

