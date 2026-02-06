namespace TPFinalNivel2_Molina
{
    partial class NuevoRegistro
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
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblImagen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxCodigo = new System.Windows.Forms.TextBox();
            this.TbxPrecio = new System.Windows.Forms.TextBox();
            this.TbxImagen = new System.Windows.Forms.TextBox();
            this.TbxDescripcion = new System.Windows.Forms.TextBox();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.CbxMarca = new System.Windows.Forms.ComboBox();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.PbxNuevo = new System.Windows.Forms.PictureBox();
            this.BtnExaminarImagen = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(31, 53);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(71, 19);
            this.LblCodigo.TabIndex = 0;
            this.LblCodigo.Text = "Codigo :";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(31, 101);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(80, 19);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre :";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(31, 139);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(64, 19);
            this.LblMarca.TabIndex = 2;
            this.LblMarca.Text = "Marca :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripcion :";
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.Location = new System.Drawing.Point(31, 231);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(113, 19);
            this.LblImagen.TabIndex = 5;
            this.LblImagen.Text = "Imagen (Url) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio :";
            // 
            // TbxCodigo
            // 
            this.TbxCodigo.Location = new System.Drawing.Point(150, 50);
            this.TbxCodigo.Name = "TbxCodigo";
            this.TbxCodigo.Size = new System.Drawing.Size(149, 27);
            this.TbxCodigo.TabIndex = 7;
            // 
            // TbxPrecio
            // 
            this.TbxPrecio.Location = new System.Drawing.Point(150, 334);
            this.TbxPrecio.Name = "TbxPrecio";
            this.TbxPrecio.Size = new System.Drawing.Size(149, 27);
            this.TbxPrecio.TabIndex = 8;
            // 
            // TbxImagen
            // 
            this.TbxImagen.Location = new System.Drawing.Point(150, 227);
            this.TbxImagen.Name = "TbxImagen";
            this.TbxImagen.Size = new System.Drawing.Size(101, 27);
            this.TbxImagen.TabIndex = 9;
            this.TbxImagen.Leave += new System.EventHandler(this.TbxImagen_Leave);
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.Location = new System.Drawing.Point(150, 266);
            this.TbxDescripcion.Multiline = true;
            this.TbxDescripcion.Name = "TbxDescripcion";
            this.TbxDescripcion.Size = new System.Drawing.Size(149, 57);
            this.TbxDescripcion.TabIndex = 10;
            // 
            // TbxNombre
            // 
            this.TbxNombre.Location = new System.Drawing.Point(150, 93);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(149, 27);
            this.TbxNombre.TabIndex = 11;
            // 
            // CbxMarca
            // 
            this.CbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMarca.FormattingEnabled = true;
            this.CbxMarca.Location = new System.Drawing.Point(150, 136);
            this.CbxMarca.Name = "CbxMarca";
            this.CbxMarca.Size = new System.Drawing.Size(149, 27);
            this.CbxMarca.TabIndex = 12;
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(150, 175);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(149, 27);
            this.CbxCategoria.TabIndex = 13;
            // 
            // PbxNuevo
            // 
            this.PbxNuevo.Location = new System.Drawing.Point(323, 50);
            this.PbxNuevo.Name = "PbxNuevo";
            this.PbxNuevo.Size = new System.Drawing.Size(202, 190);
            this.PbxNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxNuevo.TabIndex = 14;
            this.PbxNuevo.TabStop = false;
            // 
            // BtnExaminarImagen
            // 
            this.BtnExaminarImagen.Location = new System.Drawing.Point(258, 227);
            this.BtnExaminarImagen.Name = "BtnExaminarImagen";
            this.BtnExaminarImagen.Size = new System.Drawing.Size(41, 26);
            this.BtnExaminarImagen.TabIndex = 15;
            this.BtnExaminarImagen.Text = "+";
            this.BtnExaminarImagen.UseVisualStyleBackColor = true;
            this.BtnExaminarImagen.Click += new System.EventHandler(this.BtnExaminarImagen_Click);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(323, 266);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(202, 37);
            this.BtnCargar.TabIndex = 16;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(323, 319);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(202, 37);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // NuevoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(571, 384);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.BtnExaminarImagen);
            this.Controls.Add(this.PbxNuevo);
            this.Controls.Add(this.CbxCategoria);
            this.Controls.Add(this.CbxMarca);
            this.Controls.Add(this.TbxNombre);
            this.Controls.Add(this.TbxDescripcion);
            this.Controls.Add(this.TbxImagen);
            this.Controls.Add(this.TbxPrecio);
            this.Controls.Add(this.TbxCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblImagen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodigo);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NuevoRegistro";
            this.Text = "NuevoRegistro";
            this.Load += new System.EventHandler(this.NuevoRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxNuevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblImagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxCodigo;
        private System.Windows.Forms.TextBox TbxPrecio;
        private System.Windows.Forms.TextBox TbxImagen;
        private System.Windows.Forms.TextBox TbxDescripcion;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.ComboBox CbxMarca;
        private System.Windows.Forms.ComboBox CbxCategoria;
        private System.Windows.Forms.PictureBox PbxNuevo;
        private System.Windows.Forms.Button BtnExaminarImagen;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}