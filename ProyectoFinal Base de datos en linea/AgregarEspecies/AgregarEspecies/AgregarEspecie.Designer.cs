namespace AgregarEspecies
{
    partial class AgregarEspecie
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
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_nombreCientifico = new System.Windows.Forms.TextBox();
            this.txt_nombreComun = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Descripción = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Alimentacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Talla = new System.Windows.Forms.TextBox();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.txt_Vida = new System.Windows.Forms.TextBox();
            this.txt_Gestación = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.btn_Agregar.Location = new System.Drawing.Point(555, 367);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(91, 29);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nombreCientifico
            // 
            this.txt_nombreCientifico.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txt_nombreCientifico.Location = new System.Drawing.Point(218, 31);
            this.txt_nombreCientifico.MaxLength = 250;
            this.txt_nombreCientifico.Name = "txt_nombreCientifico";
            this.txt_nombreCientifico.Size = new System.Drawing.Size(191, 25);
            this.txt_nombreCientifico.TabIndex = 1;
            // 
            // txt_nombreComun
            // 
            this.txt_nombreComun.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txt_nombreComun.Location = new System.Drawing.Point(218, 67);
            this.txt_nombreComun.MaxLength = 250;
            this.txt_nombreComun.Name = "txt_nombreComun";
            this.txt_nombreComun.Size = new System.Drawing.Size(191, 25);
            this.txt_nombreComun.TabIndex = 2;
            // 
            // txt_Color
            // 
            this.txt_Color.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txt_Color.Location = new System.Drawing.Point(218, 103);
            this.txt_Color.MaxLength = 250;
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(191, 25);
            this.txt_Color.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre científico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre común de la zona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label3.Location = new System.Drawing.Point(3, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color";
            // 
            // txt_Descripción
            // 
            this.txt_Descripción.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txt_Descripción.Location = new System.Drawing.Point(7, 187);
            this.txt_Descripción.MaxLength = 250;
            this.txt_Descripción.Multiline = true;
            this.txt_Descripción.Name = "txt_Descripción";
            this.txt_Descripción.Size = new System.Drawing.Size(335, 157);
            this.txt_Descripción.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label4.Location = new System.Drawing.Point(3, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripción (Opcional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label5.Location = new System.Drawing.Point(435, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alimentación";
            // 
            // txt_Alimentacion
            // 
            this.txt_Alimentacion.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txt_Alimentacion.Location = new System.Drawing.Point(439, 64);
            this.txt_Alimentacion.MaxLength = 250;
            this.txt_Alimentacion.Multiline = true;
            this.txt_Alimentacion.Name = "txt_Alimentacion";
            this.txt_Alimentacion.Size = new System.Drawing.Size(249, 54);
            this.txt_Alimentacion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label6.Location = new System.Drawing.Point(25, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Talla";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label7.Location = new System.Drawing.Point(25, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Peso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label8.Location = new System.Drawing.Point(25, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Vida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 14F);
            this.label9.Location = new System.Drawing.Point(25, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tiempo de gestación";
            // 
            // txt_Talla
            // 
            this.txt_Talla.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txt_Talla.Location = new System.Drawing.Point(200, 40);
            this.txt_Talla.Name = "txt_Talla";
            this.txt_Talla.Size = new System.Drawing.Size(57, 25);
            this.txt_Talla.TabIndex = 15;
            // 
            // txt_Peso
            // 
            this.txt_Peso.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txt_Peso.Location = new System.Drawing.Point(200, 71);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(57, 25);
            this.txt_Peso.TabIndex = 16;
            // 
            // txt_Vida
            // 
            this.txt_Vida.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txt_Vida.Location = new System.Drawing.Point(200, 102);
            this.txt_Vida.Name = "txt_Vida";
            this.txt_Vida.Size = new System.Drawing.Size(57, 25);
            this.txt_Vida.TabIndex = 17;
            // 
            // txt_Gestación
            // 
            this.txt_Gestación.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.txt_Gestación.Location = new System.Drawing.Point(200, 133);
            this.txt_Gestación.Name = "txt_Gestación";
            this.txt_Gestación.Size = new System.Drawing.Size(57, 25);
            this.txt_Gestación.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Gestación);
            this.groupBox1.Controls.Add(this.txt_Vida);
            this.groupBox1.Controls.Add(this.txt_Peso);
            this.groupBox1.Controls.Add(this.txt_Talla);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(366, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 182);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // AgregarEspecie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Alimentacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Descripción);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Color);
            this.Controls.Add(this.txt_nombreComun);
            this.Controls.Add(this.txt_nombreCientifico);
            this.Controls.Add(this.btn_Agregar);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.Name = "AgregarEspecie";
            this.Size = new System.Drawing.Size(705, 416);
            this.Load += new System.EventHandler(this.AgregarEspecie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_nombreCientifico;
        private System.Windows.Forms.TextBox txt_nombreComun;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Descripción;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Alimentacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Talla;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.TextBox txt_Vida;
        private System.Windows.Forms.TextBox txt_Gestación;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
