namespace TPFinalNivel2_Molina
{
    partial class VentInactivos
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
            this.DgvInactivos = new System.Windows.Forms.DataGridView();
            this.PbxInactivos = new System.Windows.Forms.PictureBox();
            this.BtnVisualizar = new System.Windows.Forms.Button();
            this.BtnRecuperar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvInactivos
            // 
            this.DgvInactivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DgvInactivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInactivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvInactivos.Location = new System.Drawing.Point(27, 202);
            this.DgvInactivos.MultiSelect = false;
            this.DgvInactivos.Name = "DgvInactivos";
            this.DgvInactivos.RowHeadersWidth = 51;
            this.DgvInactivos.RowTemplate.Height = 24;
            this.DgvInactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvInactivos.Size = new System.Drawing.Size(761, 150);
            this.DgvInactivos.TabIndex = 0;
            this.DgvInactivos.SelectionChanged += new System.EventHandler(this.DgvInactivos_SelectionChanged);
            // 
            // PbxInactivos
            // 
            this.PbxInactivos.Location = new System.Drawing.Point(27, 42);
            this.PbxInactivos.Name = "PbxInactivos";
            this.PbxInactivos.Size = new System.Drawing.Size(243, 154);
            this.PbxInactivos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxInactivos.TabIndex = 1;
            this.PbxInactivos.TabStop = false;
            // 
            // BtnVisualizar
            // 
            this.BtnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnVisualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVisualizar.Location = new System.Drawing.Point(341, 42);
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(152, 33);
            this.BtnVisualizar.TabIndex = 2;
            this.BtnVisualizar.Text = "Ver";
            this.BtnVisualizar.UseVisualStyleBackColor = false;
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // BtnRecuperar
            // 
            this.BtnRecuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnRecuperar.Location = new System.Drawing.Point(341, 96);
            this.BtnRecuperar.Name = "BtnRecuperar";
            this.BtnRecuperar.Size = new System.Drawing.Size(152, 33);
            this.BtnRecuperar.TabIndex = 3;
            this.BtnRecuperar.Text = "Recuperar";
            this.BtnRecuperar.UseVisualStyleBackColor = false;
            this.BtnRecuperar.Click += new System.EventHandler(this.BtnRecuperar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnEliminar.Location = new System.Drawing.Point(341, 152);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(152, 33);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // VentInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(798, 395);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnRecuperar);
            this.Controls.Add(this.BtnVisualizar);
            this.Controls.Add(this.PbxInactivos);
            this.Controls.Add(this.DgvInactivos);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentInactivos";
            this.Text = "Articulos Inactivos";
            this.Load += new System.EventHandler(this.VentInactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxInactivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvInactivos;
        private System.Windows.Forms.PictureBox PbxInactivos;
        private System.Windows.Forms.Button BtnVisualizar;
        private System.Windows.Forms.Button BtnRecuperar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}