namespace TPFinalNivel2_Molina
{
    partial class VentPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.PbxArticulos = new System.Windows.Forms.PictureBox();
            this.LblMarca = new System.Windows.Forms.Label();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregarNuevo = new System.Windows.Forms.Button();
            this.BtnMarcas = new System.Windows.Forms.Button();
            this.BtnInacctivos = new System.Windows.Forms.Button();
            this.BtnCategorias = new System.Windows.Forms.Button();
            this.TbxBusquedaRapida = new System.Windows.Forms.TextBox();
            this.LblBusquedaRapida = new System.Windows.Forms.Label();
            this.TbxFiltrar = new System.Windows.Forms.TextBox();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.CbxMarca = new System.Windows.Forms.ComboBox();
            this.BtnVisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvArticulos.Location = new System.Drawing.Point(29, 253);
            this.DgvArticulos.MultiSelect = false;
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.RowHeadersWidth = 51;
            this.DgvArticulos.RowTemplate.Height = 24;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(749, 211);
            this.DgvArticulos.TabIndex = 0;
            this.DgvArticulos.SelectionChanged += new System.EventHandler(this.DgvArticulos_SelectionChanged);
            // 
            // PbxArticulos
            // 
            this.PbxArticulos.Location = new System.Drawing.Point(29, 48);
            this.PbxArticulos.Name = "PbxArticulos";
            this.PbxArticulos.Size = new System.Drawing.Size(246, 180);
            this.PbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxArticulos.TabIndex = 1;
            this.PbxArticulos.TabStop = false;
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(524, 156);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(64, 19);
            this.LblMarca.TabIndex = 2;
            this.LblMarca.Text = "Marca :";
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(498, 104);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(90, 19);
            this.LblCategoria.TabIndex = 4;
            this.LblCategoria.Text = "Categoria :";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.BackColor = System.Drawing.Color.Black;
            this.BtnFiltrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFiltrar.Location = new System.Drawing.Point(501, 201);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(78, 27);
            this.BtnFiltrar.TabIndex = 5;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackColor = System.Drawing.Color.Black;
            this.BtnQuitar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnQuitar.Location = new System.Drawing.Point(297, 187);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(100, 41);
            this.BtnQuitar.TabIndex = 6;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.UseVisualStyleBackColor = false;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Black;
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnModificar.Location = new System.Drawing.Point(297, 148);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(100, 33);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregarNuevo
            // 
            this.BtnAgregarNuevo.BackColor = System.Drawing.Color.Black;
            this.BtnAgregarNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAgregarNuevo.Location = new System.Drawing.Point(297, 104);
            this.BtnAgregarNuevo.Name = "BtnAgregarNuevo";
            this.BtnAgregarNuevo.Size = new System.Drawing.Size(78, 38);
            this.BtnAgregarNuevo.TabIndex = 9;
            this.BtnAgregarNuevo.Text = "Nuevo";
            this.BtnAgregarNuevo.UseVisualStyleBackColor = false;
            this.BtnAgregarNuevo.Click += new System.EventHandler(this.BtnAgregarNuevo_Click);
            // 
            // BtnMarcas
            // 
            this.BtnMarcas.BackColor = System.Drawing.Color.Black;
            this.BtnMarcas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnMarcas.Location = new System.Drawing.Point(678, 480);
            this.BtnMarcas.Name = "BtnMarcas";
            this.BtnMarcas.Size = new System.Drawing.Size(100, 42);
            this.BtnMarcas.TabIndex = 10;
            this.BtnMarcas.Text = "Marcas";
            this.BtnMarcas.UseVisualStyleBackColor = false;
            // 
            // BtnInacctivos
            // 
            this.BtnInacctivos.BackColor = System.Drawing.Color.Black;
            this.BtnInacctivos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnInacctivos.Location = new System.Drawing.Point(444, 480);
            this.BtnInacctivos.Name = "BtnInacctivos";
            this.BtnInacctivos.Size = new System.Drawing.Size(100, 42);
            this.BtnInacctivos.TabIndex = 11;
            this.BtnInacctivos.Text = "Inactivos";
            this.BtnInacctivos.UseVisualStyleBackColor = false;
            this.BtnInacctivos.Click += new System.EventHandler(this.BtnInacctivos_Click);
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.BackColor = System.Drawing.Color.Black;
            this.BtnCategorias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCategorias.Location = new System.Drawing.Point(562, 480);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Size = new System.Drawing.Size(100, 42);
            this.BtnCategorias.TabIndex = 12;
            this.BtnCategorias.Text = "Categorias";
            this.BtnCategorias.UseVisualStyleBackColor = false;
            // 
            // TbxBusquedaRapida
            // 
            this.TbxBusquedaRapida.Location = new System.Drawing.Point(175, 495);
            this.TbxBusquedaRapida.Name = "TbxBusquedaRapida";
            this.TbxBusquedaRapida.Size = new System.Drawing.Size(100, 27);
            this.TbxBusquedaRapida.TabIndex = 13;
            // 
            // LblBusquedaRapida
            // 
            this.LblBusquedaRapida.AutoSize = true;
            this.LblBusquedaRapida.Location = new System.Drawing.Point(25, 497);
            this.LblBusquedaRapida.Name = "LblBusquedaRapida";
            this.LblBusquedaRapida.Size = new System.Drawing.Size(144, 19);
            this.LblBusquedaRapida.TabIndex = 14;
            this.LblBusquedaRapida.Text = "Busqueda rapida :";
            // 
            // TbxFiltrar
            // 
            this.TbxFiltrar.Location = new System.Drawing.Point(594, 201);
            this.TbxFiltrar.Name = "TbxFiltrar";
            this.TbxFiltrar.Size = new System.Drawing.Size(133, 27);
            this.TbxFiltrar.TabIndex = 15;
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(595, 100);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(133, 27);
            this.CbxCategoria.TabIndex = 16;
            // 
            // CbxMarca
            // 
            this.CbxMarca.FormattingEnabled = true;
            this.CbxMarca.Location = new System.Drawing.Point(594, 148);
            this.CbxMarca.Name = "CbxMarca";
            this.CbxMarca.Size = new System.Drawing.Size(133, 27);
            this.CbxMarca.TabIndex = 17;
            // 
            // BtnVisualizar
            // 
            this.BtnVisualizar.BackColor = System.Drawing.Color.Black;
            this.BtnVisualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnVisualizar.Location = new System.Drawing.Point(297, 64);
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(100, 34);
            this.BtnVisualizar.TabIndex = 18;
            this.BtnVisualizar.Text = "Ver";
            this.BtnVisualizar.UseVisualStyleBackColor = false;
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // VentPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(820, 534);
            this.Controls.Add(this.BtnVisualizar);
            this.Controls.Add(this.CbxMarca);
            this.Controls.Add(this.CbxCategoria);
            this.Controls.Add(this.TbxFiltrar);
            this.Controls.Add(this.LblBusquedaRapida);
            this.Controls.Add(this.TbxBusquedaRapida);
            this.Controls.Add(this.BtnCategorias);
            this.Controls.Add(this.BtnInacctivos);
            this.Controls.Add(this.BtnMarcas);
            this.Controls.Add(this.BtnAgregarNuevo);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.PbxArticulos);
            this.Controls.Add(this.DgvArticulos);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VentPrincipal";
            this.Text = "Sistema de control";
            this.Load += new System.EventHandler(this.VentPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.PictureBox PbxArticulos;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregarNuevo;
        private System.Windows.Forms.Button BtnMarcas;
        private System.Windows.Forms.Button BtnInacctivos;
        private System.Windows.Forms.Button BtnCategorias;
        private System.Windows.Forms.TextBox TbxBusquedaRapida;
        private System.Windows.Forms.Label LblBusquedaRapida;
        private System.Windows.Forms.TextBox TbxFiltrar;
        private System.Windows.Forms.ComboBox CbxCategoria;
        private System.Windows.Forms.ComboBox CbxMarca;
        private System.Windows.Forms.Button BtnVisualizar;
    }
}

