namespace Grupos
{
    partial class AgregarPoblaciones
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
            this.cmb_Lugares = new System.Windows.Forms.ComboBox();
            this.cmb_Ballenas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Llegada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.nup_Miembros = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Miembros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de arribo";
            // 
            // cmb_Lugares
            // 
            this.cmb_Lugares.FormattingEnabled = true;
            this.cmb_Lugares.Location = new System.Drawing.Point(194, 199);
            this.cmb_Lugares.Name = "cmb_Lugares";
            this.cmb_Lugares.Size = new System.Drawing.Size(385, 32);
            this.cmb_Lugares.TabIndex = 11;
            // 
            // cmb_Ballenas
            // 
            this.cmb_Ballenas.FormattingEnabled = true;
            this.cmb_Ballenas.Location = new System.Drawing.Point(194, 145);
            this.cmb_Ballenas.Name = "cmb_Ballenas";
            this.cmb_Ballenas.Size = new System.Drawing.Size(385, 32);
            this.cmb_Ballenas.Sorted = true;
            this.cmb_Ballenas.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lugar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Especie";
            // 
            // dtp_Llegada
            // 
            this.dtp_Llegada.Location = new System.Drawing.Point(401, 300);
            this.dtp_Llegada.MaxDate = new System.DateTime(2014, 4, 27, 0, 0, 0, 0);
            this.dtp_Llegada.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dtp_Llegada.Name = "dtp_Llegada";
            this.dtp_Llegada.Size = new System.Drawing.Size(352, 30);
            this.dtp_Llegada.TabIndex = 12;
            this.dtp_Llegada.Value = new System.DateTime(2014, 4, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Favor de ingresar los valores del grupo de ballenas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Miembros contabilizados";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(632, 170);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 38);
            this.btn_agregar.TabIndex = 16;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // nup_Miembros
            // 
            this.nup_Miembros.Location = new System.Drawing.Point(401, 361);
            this.nup_Miembros.Name = "nup_Miembros";
            this.nup_Miembros.Size = new System.Drawing.Size(120, 30);
            this.nup_Miembros.TabIndex = 17;
            // 
            // AgregarPoblaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nup_Miembros);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_Llegada);
            this.Controls.Add(this.cmb_Lugares);
            this.Controls.Add(this.cmb_Ballenas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AgregarPoblaciones";
            this.Size = new System.Drawing.Size(900, 472);
            this.Load += new System.EventHandler(this.AgregarPoblaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_Miembros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Lugares;
        private System.Windows.Forms.ComboBox cmb_Ballenas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Llegada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.NumericUpDown nup_Miembros;
    }
}
