namespace Grupos
{
    partial class Agregar_Ballena
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbt_ConEtapa = new System.Windows.Forms.RadioButton();
            this.rbt_Año = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_EtapaVida = new System.Windows.Forms.ComboBox();
            this.txt_Año = new System.Windows.Forms.TextBox();
            this.rbt_Bebe = new System.Windows.Forms.RadioButton();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_Alias = new System.Windows.Forms.TextBox();
            this.txt_Longitud = new System.Windows.Forms.TextBox();
            this.rbt_Sexo = new System.Windows.Forms.RadioButton();
            this.rbt_Hembra = new System.Windows.Forms.RadioButton();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexo ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Longitud";
            // 
            // rbt_ConEtapa
            // 
            this.rbt_ConEtapa.AutoSize = true;
            this.rbt_ConEtapa.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_ConEtapa.Location = new System.Drawing.Point(357, 93);
            this.rbt_ConEtapa.Name = "rbt_ConEtapa";
            this.rbt_ConEtapa.Size = new System.Drawing.Size(139, 27);
            this.rbt_ConEtapa.TabIndex = 4;
            this.rbt_ConEtapa.TabStop = true;
            this.rbt_ConEtapa.Text = "Etapa definida";
            this.rbt_ConEtapa.UseVisualStyleBackColor = true;
            // 
            // rbt_Año
            // 
            this.rbt_Año.AutoSize = true;
            this.rbt_Año.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Año.Location = new System.Drawing.Point(46, 93);
            this.rbt_Año.Name = "rbt_Año";
            this.rbt_Año.Size = new System.Drawing.Size(151, 27);
            this.rbt_Año.TabIndex = 5;
            this.rbt_Año.TabStop = true;
            this.rbt_Año.Text = "Año nacimiento";
            this.rbt_Año.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_EtapaVida);
            this.groupBox1.Controls.Add(this.txt_Año);
            this.groupBox1.Controls.Add(this.rbt_Bebe);
            this.groupBox1.Controls.Add(this.rbt_ConEtapa);
            this.groupBox1.Controls.Add(this.rbt_Año);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(124, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 194);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De la edad";
            // 
            // cbx_EtapaVida
            // 
            this.cbx_EtapaVida.FormattingEnabled = true;
            this.cbx_EtapaVida.Location = new System.Drawing.Point(357, 134);
            this.cbx_EtapaVida.Name = "cbx_EtapaVida";
            this.cbx_EtapaVida.Size = new System.Drawing.Size(228, 37);
            this.cbx_EtapaVida.TabIndex = 8;
            // 
            // txt_Año
            // 
            this.txt_Año.Location = new System.Drawing.Point(64, 134);
            this.txt_Año.Name = "txt_Año";
            this.txt_Año.Size = new System.Drawing.Size(187, 37);
            this.txt_Año.TabIndex = 7;
            this.txt_Año.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Año_KeyPress);
            // 
            // rbt_Bebe
            // 
            this.rbt_Bebe.AutoSize = true;
            this.rbt_Bebe.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Bebe.Location = new System.Drawing.Point(46, 47);
            this.rbt_Bebe.Name = "rbt_Bebe";
            this.rbt_Bebe.Size = new System.Drawing.Size(136, 27);
            this.rbt_Bebe.TabIndex = 6;
            this.rbt_Bebe.TabStop = true;
            this.rbt_Bebe.Text = "Recien Nacida";
            this.rbt_Bebe.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(522, 106);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(98, 38);
            this.btn_Agregar.TabIndex = 9;
            this.btn_Agregar.Text = "Listo";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_Alias
            // 
            this.txt_Alias.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Alias.Location = new System.Drawing.Point(206, 56);
            this.txt_Alias.Name = "txt_Alias";
            this.txt_Alias.Size = new System.Drawing.Size(220, 28);
            this.txt_Alias.TabIndex = 10;
            this.txt_Alias.TextChanged += new System.EventHandler(this.txt_Alias_TextChanged);
            // 
            // txt_Longitud
            // 
            this.txt_Longitud.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Longitud.Location = new System.Drawing.Point(208, 172);
            this.txt_Longitud.Name = "txt_Longitud";
            this.txt_Longitud.Size = new System.Drawing.Size(218, 28);
            this.txt_Longitud.TabIndex = 11;
            this.txt_Longitud.TextChanged += new System.EventHandler(this.txt_Longitud_TextChanged);
            // 
            // rbt_Sexo
            // 
            this.rbt_Sexo.AutoSize = true;
            this.rbt_Sexo.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Sexo.Location = new System.Drawing.Point(225, 112);
            this.rbt_Sexo.Name = "rbt_Sexo";
            this.rbt_Sexo.Size = new System.Drawing.Size(81, 27);
            this.rbt_Sexo.TabIndex = 12;
            this.rbt_Sexo.TabStop = true;
            this.rbt_Sexo.Text = "Macho";
            this.rbt_Sexo.UseVisualStyleBackColor = true;
            // 
            // rbt_Hembra
            // 
            this.rbt_Hembra.AutoSize = true;
            this.rbt_Hembra.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_Hembra.Location = new System.Drawing.Point(336, 112);
            this.rbt_Hembra.Name = "rbt_Hembra";
            this.rbt_Hembra.Size = new System.Drawing.Size(91, 27);
            this.rbt_Hembra.TabIndex = 13;
            this.rbt_Hembra.TabStop = true;
            this.rbt_Hembra.Text = "Hembra";
            this.rbt_Hembra.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(679, 106);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(98, 38);
            this.btn_Cancelar.TabIndex = 14;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Agregar_Ballena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.rbt_Hembra);
            this.Controls.Add(this.rbt_Sexo);
            this.Controls.Add(this.txt_Longitud);
            this.Controls.Add(this.txt_Alias);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Agregar_Ballena";
            this.Size = new System.Drawing.Size(900, 472);
            this.Load += new System.EventHandler(this.Agregar_Ballena_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbt_ConEtapa;
        private System.Windows.Forms.RadioButton rbt_Año;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Año;
        private System.Windows.Forms.RadioButton rbt_Bebe;
        private System.Windows.Forms.ComboBox cbx_EtapaVida;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_Alias;
        private System.Windows.Forms.TextBox txt_Longitud;
        private System.Windows.Forms.RadioButton rbt_Sexo;
        private System.Windows.Forms.RadioButton rbt_Hembra;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}
