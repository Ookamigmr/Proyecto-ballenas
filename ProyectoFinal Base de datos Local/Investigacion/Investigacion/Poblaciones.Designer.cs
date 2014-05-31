namespace Grupos
{
    partial class Poblaciones
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
            this.ltb_Poblaciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NuevaPoblación = new System.Windows.Forms.Button();
            this.ltb_Ballenas = new System.Windows.Forms.ListBox();
            this.btn_ExaminarPoblación = new System.Windows.Forms.Button();
            this.btn_Comparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltb_Poblaciones
            // 
            this.ltb_Poblaciones.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltb_Poblaciones.FormattingEnabled = true;
            this.ltb_Poblaciones.ItemHeight = 21;
            this.ltb_Poblaciones.Location = new System.Drawing.Point(33, 119);
            this.ltb_Poblaciones.Name = "ltb_Poblaciones";
            this.ltb_Poblaciones.Size = new System.Drawing.Size(326, 298);
            this.ltb_Poblaciones.TabIndex = 0;
            this.ltb_Poblaciones.SelectedIndexChanged += new System.EventHandler(this.ltb_Poblaciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de poblaciones en la zona";
            // 
            // btn_NuevaPoblación
            // 
            this.btn_NuevaPoblación.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaPoblación.Location = new System.Drawing.Point(384, 119);
            this.btn_NuevaPoblación.Name = "btn_NuevaPoblación";
            this.btn_NuevaPoblación.Size = new System.Drawing.Size(141, 71);
            this.btn_NuevaPoblación.TabIndex = 2;
            this.btn_NuevaPoblación.Text = "Nueva Población";
            this.btn_NuevaPoblación.UseVisualStyleBackColor = true;
            this.btn_NuevaPoblación.Click += new System.EventHandler(this.btn_NuevaPoblación_Click);
            // 
            // ltb_Ballenas
            // 
            this.ltb_Ballenas.FormattingEnabled = true;
            this.ltb_Ballenas.ItemHeight = 24;
            this.ltb_Ballenas.Location = new System.Drawing.Point(541, 119);
            this.ltb_Ballenas.Name = "ltb_Ballenas";
            this.ltb_Ballenas.Size = new System.Drawing.Size(326, 316);
            this.ltb_Ballenas.TabIndex = 3;
            // 
            // btn_ExaminarPoblación
            // 
            this.btn_ExaminarPoblación.Enabled = false;
            this.btn_ExaminarPoblación.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExaminarPoblación.Location = new System.Drawing.Point(384, 234);
            this.btn_ExaminarPoblación.Name = "btn_ExaminarPoblación";
            this.btn_ExaminarPoblación.Size = new System.Drawing.Size(141, 71);
            this.btn_ExaminarPoblación.TabIndex = 4;
            this.btn_ExaminarPoblación.Text = "Examinar Población";
            this.btn_ExaminarPoblación.UseVisualStyleBackColor = true;
            this.btn_ExaminarPoblación.Click += new System.EventHandler(this.btn_ExaminarPoblación_Click);
            // 
            // btn_Comparar
            // 
            this.btn_Comparar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comparar.Location = new System.Drawing.Point(384, 359);
            this.btn_Comparar.Name = "btn_Comparar";
            this.btn_Comparar.Size = new System.Drawing.Size(141, 71);
            this.btn_Comparar.TabIndex = 5;
            this.btn_Comparar.Text = "Comparar Poblaciones";
            this.btn_Comparar.UseVisualStyleBackColor = true;
            this.btn_Comparar.Click += new System.EventHandler(this.btn_Comparar_Click);
            // 
            // Poblaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Comparar);
            this.Controls.Add(this.btn_ExaminarPoblación);
            this.Controls.Add(this.ltb_Ballenas);
            this.Controls.Add(this.btn_NuevaPoblación);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltb_Poblaciones);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Poblaciones";
            this.Size = new System.Drawing.Size(900, 472);
            this.Load += new System.EventHandler(this.Poblaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_Poblaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevaPoblación;
        private System.Windows.Forms.ListBox ltb_Ballenas;
        private System.Windows.Forms.Button btn_ExaminarPoblación;
        private System.Windows.Forms.Button btn_Comparar;
    }
}
