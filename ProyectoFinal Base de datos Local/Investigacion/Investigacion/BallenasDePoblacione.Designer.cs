﻿namespace Grupos
{
    partial class BallenasDePoblacione
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
            this.dgv_Ballenas = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ballenas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Ballenas
            // 
            this.dgv_Ballenas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ballenas.Location = new System.Drawing.Point(3, 109);
            this.dgv_Ballenas.Name = "dgv_Ballenas";
            this.dgv_Ballenas.Size = new System.Drawing.Size(516, 148);
            this.dgv_Ballenas.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(359, 287);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(108, 33);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar Ballen a esta población";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ballenas registradas de la población";
            // 
            // BallenasDePoblacione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv_Ballenas);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BallenasDePoblacione";
            this.Size = new System.Drawing.Size(522, 352);
            this.Load += new System.EventHandler(this.BallenasDePoblacione_Load);
            this.Enter += new System.EventHandler(this.BallenasDePoblacione_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ballenas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Ballenas;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label1;
    }
}
