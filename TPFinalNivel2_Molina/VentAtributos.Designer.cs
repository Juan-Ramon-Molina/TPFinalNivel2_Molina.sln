namespace TPFinalNivel2_Molina
{
    partial class VentAtributos
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvAtributos = new System.Windows.Forms.DataGridView();
            this.TbxAgregar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAtributos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnAgregar.Location = new System.Drawing.Point(44, 234);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(191, 49);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar  nombre=>";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvAtributos
            // 
            this.DgvAtributos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAtributos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DgvAtributos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAtributos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvAtributos.Location = new System.Drawing.Point(44, 47);
            this.DgvAtributos.MultiSelect = false;
            this.DgvAtributos.Name = "DgvAtributos";
            this.DgvAtributos.RowHeadersWidth = 51;
            this.DgvAtributos.RowTemplate.Height = 24;
            this.DgvAtributos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAtributos.Size = new System.Drawing.Size(460, 181);
            this.DgvAtributos.TabIndex = 1;
            // 
            // TbxAgregar
            // 
            this.TbxAgregar.Location = new System.Drawing.Point(241, 246);
            this.TbxAgregar.Name = "TbxAgregar";
            this.TbxAgregar.Size = new System.Drawing.Size(263, 27);
            this.TbxAgregar.TabIndex = 2;
            // 
            // VentAtributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(582, 313);
            this.Controls.Add(this.TbxAgregar);
            this.Controls.Add(this.DgvAtributos);
            this.Controls.Add(this.BtnAgregar);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "VentAtributos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentAtributos";
            this.Load += new System.EventHandler(this.VentAtributos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAtributos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvAtributos;
        private System.Windows.Forms.TextBox TbxAgregar;
    }
}